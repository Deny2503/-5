namespace Урок5
{
    public partial class Form1 : Form
    {
        private bool isFileOpened = false;
        private bool isTextChanged = false;
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
            richTextBox1.TextChanged += (s, e) => { isTextChanged = true; UpdateSaveButtonState(); };
            btnSave.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Выберите текстовый файл",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                    isFileOpened = true;
                    isTextChanged = false;
                    UpdateSaveButtonState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFileOpened)
            {
                try
                {
                    File.WriteAllText("savedFile.txt", richTextBox1.Text);
                    isTextChanged = false;
                    MessageBox.Show("Файл успешно сохранён!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Сохранить файл как...",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                DefaultExt = "txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    currentFilePath = saveFileDialog.FileName;
                    isTextChanged = false;
                    MessageBox.Show("Файл успешно сохранён как новый!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateSaveButtonState()
        {
            btnSave.Enabled = !string.IsNullOrEmpty(richTextBox1.Text) && isFileOpened && isTextChanged;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isTextChanged)
            {
                var res = MessageBox.Show("У вас есть несохранённые изменения. Хотите сохранить перед выходом?", "Підтвердження", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                    e.Cancel = false;
                }
                else if (res == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
