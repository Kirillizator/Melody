﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Melody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60; //продолжительность игры
        static public int musicDuration = 10; //время до следующей композиции
        static public bool randomStart = false; //начинать композицию с начала или со случайного места
        static public string lastFolder = ""; //выбраная папка с музыкой
        static public bool allDirectories = false; //обработка вложенных директорий

        static public void ReadMusic() //void - метод
        {
            try
            {
                string[] music_files = Directory.GetFiles(lastFolder, "*.*", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music_files);
            }
            catch
            {
            }
        }


        static string regKeyName = "Software\\Kirillizator\\MelodyVictorina";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }

        }
    }
}
