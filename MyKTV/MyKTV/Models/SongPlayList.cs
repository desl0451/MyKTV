using System;
using System.Collections.Generic;
using System.Text;

namespace MyKTV
{
    public enum PlayState
    {
        播放, 重播, 停止, 上一首, 下一首
    }
    public class SongPlayList
    {
        private static int index = 0;
        private static Song[] songlist = new Song[50];
        private static Song song = new Song();//要播放的歌曲

        #region 0.获得歌曲
        public static Song Song
        {
            get { return SongPlayList.song; }

        }
        #endregion

        #region 1.获得播放列表
        /// <summary>
        /// 获得播放列表
        /// </summary>
        public static Song[] Songlist
        {
            get { return SongPlayList.songlist; }
        }
        #endregion

        #region 2.播放
        /// <summary>
        /// 播放
        /// </summary>
        /// <returns></returns>
        public static void PlaySong()
        {
            song = songlist[index];
        }
        #endregion

        #region 3.添加歌曲名称
        /// <summary>
        /// 添加歌曲名称
        /// </summary>
        public static void addPlayMusic(Song song)
        {
            for (int i = 0; i < songlist.Length; i++)
            {
                if (songlist[i] == null)
                {
                    songlist[i] = song;
                    break;
                }
            }
        }
        #endregion

        #region 4.播放方法
        /// <summary>
        /// 播放方法
        /// </summary>
        public static void playMusic()
        {
            if (songlist[index] != null)
            {
                songlist[index].PlayState = PlayState.播放;
                song = songlist[index];
            }

        }
        #endregion

        #region 5.获得歌曲
        /// <summary>
        /// 获得歌曲
        /// </summary>
        /// <returns></returns>
        public static void getSong()
        {
            if (songlist[index] != null)
            {
                song = songlist[index];
            }
            else
            {
                song = null;
            }
        }
        #endregion

        #region 6.切歌
        /// <summary>
        /// 切歌
        /// </summary>
        public static void CutSong()
        {
            index++;
            if (index == songlist.Length)
            {
                index = 0;
            }
            if (songlist[index] != null)
            {
                song = songlist[index];
            }
            else
            {
                song = null;
            }

        }
        #endregion

        #region 7.第一首歌曲
        public static void firstSong()
        {
            index = 0;
            if (songlist[index] != null)
            {
                song = songlist[index];
            }
            else
            {
                song = null;
            }
        }
        #endregion

        #region 8.最后一首歌曲
        public static void lastSong()
        {
            int IndexOf = 0;
            for (int i = 0; i < songlist.Length; i++)
            {
                if (songlist[i] == null)
                {
                    IndexOf = i;
                    break;
                }
            }
            index = IndexOf - 1;
            if (songlist[index] != null)
            {
                song = songlist[index];
            }
            else
            {
                song = null;
            }
        }
        #endregion

        #region 9.上一首歌曲
        public static void backSong()
        {
            index--;
            if (index != -1)
            {
                song = songlist[index];
            }
            else
            {
                song = null;
            }
        }
        #endregion

        #region 10.下一首歌曲
        public static void nextSong()
        {
            index++;
            if (index < 50)
            {
                if (songlist[index] != null)
                {
                    song = songlist[index];
                }
                else
                {
                    song = null;
                }
            }
            else
            {
                song = null;
            }
        }
        #endregion
    }
}
