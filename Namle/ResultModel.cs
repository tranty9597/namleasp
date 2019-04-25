using System;
namespace Namle
{
    public class ResultModel
    {
        bool success;

        public AbcModel value;

        public ResultModel(bool success, AbcModel value)
        {
            this.success = success;
            this.value = value;
        }
    }
}
