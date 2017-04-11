using System;

namespace Shadowsocks.Model
{
    /*
     * Format:
     *  <modifiers-combination>+<key>
     *
     */
    /// <summary>
    /// 热键
    /// </summary>
    [Serializable]
    public class HotkeyConfig
    {
        public string SwitchSystemProxy;
        public string SwitchSystemProxyMode;
        public string SwitchAllowLan;
        public string ShowLogs;
        public string ServerMoveUp;
        public string ServerMoveDown;

        public HotkeyConfig()
        {
            SwitchSystemProxy = "";
            SwitchSystemProxyMode = "";
            SwitchAllowLan = "";
            ShowLogs = "";
            ServerMoveUp = "";
            ServerMoveDown = "";
        }
    }
}