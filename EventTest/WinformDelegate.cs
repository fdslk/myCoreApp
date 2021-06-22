using System;

namespace EventTest
{
    public class WinformDelegate
    {
        public WinformDelegate(){
        }
        public void ClickEvent(bool judge)
        {
            if(judge){
                OnClickReached(EventArgs.Empty);
            }
        }

        private void OnClickReached(EventArgs e)
        {
            EventHandler handler = ClickHandler;
            if(handler != null){
                handler(this, e);
            }
        }

        public event EventHandler ClickHandler;
    }
}