using System.Windows.Input;
using Sample.Core;
using ICommand = Sample.Core.ICommand;

namespace Sample.Bl.Commnad
{
    public class SampleInsertCommand : ICommand
    {
        public int SampleId{get; set;}
        public string SampleName { get; set; }
    }
}