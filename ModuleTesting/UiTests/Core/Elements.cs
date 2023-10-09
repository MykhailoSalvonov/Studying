using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA2;

namespace UiTests.Core
{
    public class Elements
    {
        public static Window FindWindow(Func<ConditionFactory, ConditionBase> conditionFunc) 
        {
            using (var automation = new UIA2Automation())
            {
                return automation.GetDesktop().FindFirstChild(conditionFunc).AsWindow();
            }
        }
    }
}
