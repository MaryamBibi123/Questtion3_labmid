using System;
using System.Windows.Forms;

namespace Questtion3_labmid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string command = textBoxCommand.Text.Trim();
            string result = ParseCommand(command);
            labelResult.Text = result;
        }

        private string ParseCommand(string command)
        {
            // Split the command into parts
            string[] parts = command.Split(' ');

            if (parts.Length == 0)
            {
                return "Invalid command. Please enter a command.";
            }

            // Start parsing commands
            if (parts[0].Equals("Start", StringComparison.OrdinalIgnoreCase))
            {
                if (parts.Length == 1)
                {
                    return "Car started.";
                }

                string actionResult = "";
                for (int i = 1; i < parts.Length; i++)
                {
                    if (parts[i].Equals("Accelerate", StringComparison.OrdinalIgnoreCase))
                    {
                        actionResult = "Car is accelerating.";
                    }
                    else if (parts[i].Equals("Stop", StringComparison.OrdinalIgnoreCase))
                    {
                        actionResult = "Car stopped.";
                    }
                    else if (parts[i].Equals("Right", StringComparison.OrdinalIgnoreCase))
                    {
                        actionResult = "Car turned right.";
                    }
                    else if (parts[i].Equals("Left", StringComparison.OrdinalIgnoreCase))
                    {
                        return "Error: The car cannot turn left.";
                    }
                    else
                    {
                        return "Invalid action: " + parts[i];
                    }
                }

                // Return the last action result or default to starting message if no valid actions
                return actionResult != "" ? actionResult : "Car started.";
            }

            return "Invalid command. Please start with 'Start'.";
        }

        private void textBoxCommand_GotFocus(object sender, EventArgs e)
        {
            if (textBoxCommand.Text == "Enter command (e.g., Start Right)")
            {
                textBoxCommand.Text = "";
                textBoxCommand.ForeColor = System.Drawing.Color.Black; // Change text color to black
            }
        }

        private void textBoxCommand_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCommand.Text))
            {
                textBoxCommand.Text = "Enter command (e.g., Start Right)";
                textBoxCommand.ForeColor = System.Drawing.Color.Gray; // Reset placeholder color
            }
        }
    }
}
