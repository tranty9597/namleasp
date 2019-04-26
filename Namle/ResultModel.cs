using System;
namespace Namle
{
    public class ResultModel
    {
        bool success;

        public AbcModel value;

        Object error;

        public ResultModel() {
            success = false;
            value = new AbcModel();
        }

        public ResultModel(bool success, AbcModel value)
        {
            this.success = success;
            this.value = value;
        }
    }
}
