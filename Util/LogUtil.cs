﻿using System;
using System.Text;
using UnityEngine;
using CM3D2.AlwaysColorChange.Plugin;

namespace CM3D2.AlwaysColorChange.Plugin.Util
{
    /// <summary>
    /// Description of Class1.
    /// </summary>
    public static class LogUtil
    {

        public static void DebugLog(params object[] message)
        {
#if DEBUG
            var sb = createMesage(message);
            Debug.Log(sb);
#endif
        }

        public static void Log(params object[] message)
        {
            var sb = createMesage(message);
            Debug.Log(sb);
        }

        public static void ErrorLog(params object[] message)
        {
            var sb = createMesage(message);
            Debug.LogError(sb);
        }

        private static StringBuilder createMesage(object[] message) 
        {
            var sb = new StringBuilder();
            sb.Append(AlwaysColorChange.PluginName).Append(':');
            for (int i = 0; i < message.Length; i++) {
                if (i > 0) sb.Append(',');
                sb.Append(message[i]);
            }
            return sb;
        }
    }
}
