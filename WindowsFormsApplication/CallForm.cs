using Components.CallPROVIDER;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class CallForm : Form
    {
        public CallForm()
        {
            InitializeComponent();
        }
        public void UpdateCalls(Dictionary<string, (List<Call>, List<Call>)> callCach) 
        {
            CallsTreeView.Nodes.Clear();
            foreach (var call in callCach)
            {
                if (call.Value.Item1.Any()) 
                {
                    TreeNode contactIncomingNode = new TreeNode()
                    {
                        Name = call.Key + " incoming",
                        Text = call.Key + " incoming",
                    };
                    foreach (var incomingCall in call.Value.Item1) 
                    {
                        TreeNode incomingCallNode = new TreeNode()
                        {
                            Name = incomingCall.Contact.Name + " " + incomingCall.DateTime.ToString(),
                            Text = incomingCall.DateTime.ToString()
                        };
                        contactIncomingNode.Nodes.Add(incomingCallNode);
                    }
                    CallsTreeView.Nodes.Add(contactIncomingNode);
                }
                if (call.Value.Item2.Any())
                {
                    TreeNode contactOutgoingNode = new TreeNode()
                    {
                        Name = call.Key + " outgoing",
                        Text = call.Key + " outgoing",
                    };
                    foreach (var outgoingCall in call.Value.Item2)
                    {
                        TreeNode outgoingCallNode = new TreeNode()
                        {
                            Name = outgoingCall.Contact.Name + " " + outgoingCall.DateTime.ToString(),
                            Text = outgoingCall.DateTime.ToString()
                        };
                        contactOutgoingNode.Nodes.Add(outgoingCallNode);
                    }
                    CallsTreeView.Nodes.Add(contactOutgoingNode);
                }
            }
        }
    }
}
