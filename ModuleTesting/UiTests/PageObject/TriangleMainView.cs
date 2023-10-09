using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiTests.Core;

namespace UiTests.PageObject
{
    public class TriangleMainView
    {
        public TriangleMainView() 
        {
            Window window = Elements.FindWindow(w => w.ByName("TriangleBuilder"));

            _sizeA = window.FindFirstDescendant(e => e.ByAutomationId("sizeA")).AsTextBox();
            _sizeB = window.FindFirstDescendant(e => e.ByAutomationId("sizeB")).AsTextBox();
            _sizeC = window.FindFirstDescendant(e => e.ByAutomationId("sizeC")).AsTextBox();

            _create = window.FindFirstDescendant(e => e.ByAutomationId("createBtn")).AsButton();
            _message = window.FindFirstDescendant(e => e.ByAutomationId("resultLabel")).AsLabel();

        }

        public int SizeA
        {
            get => TryGetInt(_sizeA.Text);
            set => _sizeA.Text = value.ToString();
        }

        public int SizeB
        {
            get => TryGetInt(_sizeB.Text);
            set => _sizeB.Text = value.ToString();
        }

        public int SizeC
        {
            get => TryGetInt(_sizeC.Text);
            set => _sizeC.Text = value.ToString();
        }


        public string Message => _message.Text;

        public void Create()
        {
            _create.Click();
            Thread.Sleep(1000);
        }

        private int TryGetInt(string num)
        {
            if (int.TryParse(num, out int result))
                return result;

            throw new ArgumentException("Cannot convert argument to int.");
        }

        private TextBox _sizeA;
        private TextBox _sizeB;
        private TextBox _sizeC;

        private Button _create;
        private Label _message;
    }
}
