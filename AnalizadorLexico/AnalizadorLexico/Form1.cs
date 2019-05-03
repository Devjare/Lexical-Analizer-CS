using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {

        #region "Form behaviour"
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        // Identificador para inicio y fin de bloque.
        // identificador para fin de linea.
        bool isErrorPanelCollapsed = false;
        const int ERROR_PANEL_MAX_WIDTH = 190;

        Lexer lexer;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            CheckKeyword("let", Color.Blue, 0);
            CheckKeyword("for", Color.Blue, 0);
            CheckKeyword("while", Color.Blue, 0);
            CheckKeyword("if", Color.Blue, 0);
            CheckKeyword("else", Color.Blue, 0);
            CheckKeyword("to", Color.Blue, 0);
            CheckKeyword("be", Color.Blue, 0);
            CheckKeyword("new", Color.Blue, 0);
            CheckKeyword("repeat", Color.Blue, 0);
            CheckKeyword("imports", Color.Blue, 0);
            CheckKeyword("int", Color.Blue, 0);
            CheckKeyword("string", Color.Blue, 0);
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.txtCode.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.txtCode.SelectionStart;

                while ((index = this.txtCode.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.txtCode.Select((index + startIndex), word.Length);
                    this.txtCode.SelectionColor = color;
                    this.txtCode.Select(selectStart, 0);
                    this.txtCode.SelectionColor = Color.Black;
                }
            }
        }

        private void ClearDGV()
        {
            dgvTokens.Rows.Clear();
        }

        private void AddRow(string lexem, string token, string value)
        {
            dgvTokens.Rows.Add(lexem, token, value);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void topPane_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        const string TAB = "    ";
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode.Equals(Keys.Tab))
            //{
            //    txtCode.Text += TAB;
            //} 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCode.SelectionTabs = new int[] { 50, 100, 200, 300 };
            txtCode.Font = new Font("Consolas", 12);
            txtCode.ForeColor = Color.Black;

            // Test Purposes, fill as default with some code.
            var path = "C:\\Users\\Andres\\source\\repos\\AnalizadorLexico\\AnalizadorLexico\\CodeSamples\\main.rst";
            var stream = new System.IO.StreamReader(path);
            String line;
            while ((line = stream.ReadLine()) != null)
            {
                txtCode.Text += line += "\n";
            }
        }

        private void txtCode_SelectionChanged(object sender, EventArgs e)
        {
            var index = txtCode.SelectionStart;
            var line = txtCode.GetLineFromCharIndex(index);
            var col = txtCode.SelectionStart - txtCode.GetFirstCharIndexFromLine(line);
            lblLines.Text = $"LINE: {line}";
            lblColumn.Text = $"COL: {col}";
        }


        private void WriteTextToRichTextBox()
        {
            // Clear all text from the RichTextBox;
            txtCode.Clear();
            // Set the font for the opening text to a larger Arial font;
            txtCode.SelectionFont = new Font("Arial", 16);
            // Assign the introduction text to the RichTextBox control.
            txtCode.SelectedText = "The following is a list of bulleted items:" + "\n";
            // Set the Font for the first item to a smaller size Arial font.
            txtCode.SelectionFont = new Font("Arial", 12);
            // Specify that the following items are to be added to a bulleted list.
            txtCode.SelectionBullet = true;
            // Set the color of the item text.
            txtCode.SelectionColor = Color.Red;
            // Assign the text to the bulleted item.
            txtCode.SelectedText = "Apples" + "\n";
            // Apply same font since font settings do not carry to next line.
            // End the bulleted list.
            txtCode.SelectionFont = new Font("Arial", 12);
            txtCode.SelectionColor = Color.Orange;
            txtCode.SelectedText = "Oranges" + "\n";
            txtCode.SelectionFont = new Font("Arial", 12);
            txtCode.SelectionColor = Color.Purple;
            txtCode.SelectedText = "Grapes" + "\n";
            txtCode.SelectionBullet = false;
            // Specify the font size and string for text displayed below bulleted list.
            txtCode.SelectionFont = new Font("Arial", 16);
            txtCode.SelectedText = "Bulleted Text Complete!";
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            ClearDGV();
            lexer = new Lexer(txtCode.Text);
            Token token;

            token = lexer.NextToken();

            while (token.Type != TokenType.END_OF_FILE)
            {
                if (token.Value != null)
                {
                    AddRow(token.Text, token.Type.ToString(), token.Value.ToString());
                }
                else
                {
                    AddRow(token.Text, token.Type.ToString(), "");
                }

                token = lexer.NextToken();
            }

        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                var stream = new System.IO.StreamReader(dialog.FileName.ToString());
                String line;
                while ((line = stream.ReadLine()) != null)
                {
                    txtCode.Text += line += "\n";
                }

            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
            
        }
    }
}
