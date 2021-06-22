using System;

namespace EventTest
{
    public class ClickReachedEevntArgs: EventArgs{
        private bool isClick;

        public bool IsClick { get => isClick; set => isClick = value; }
    }
}