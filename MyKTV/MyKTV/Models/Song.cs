using System;
using System.Collections.Generic;
using System.Text;

namespace MyKTV
{
    public class Song
    {
        private PlayState playState;
        /// <summary>
        /// 播放状态
        /// </summary>
        public PlayState PlayState
        {
            get { return playState; }
            set { playState = value; }
        }
        private int song_id;
        /// <summary>
        /// 播放ID
        /// </summary>
        public int Song_id
        {
            get { return song_id; }
            set { song_id = value; }
        }
        private string song_name;
        /// <summary>
        /// 歌曲名称
        /// </summary>
        public string Song_name
        {
            get { return song_name; }
            set { song_name = value; }
        }

        private string song_url;
        /// <summary>
        /// 歌曲路径
        /// </summary>
        public string Song_url
        {
            get { return song_url; }
            set { song_url = value; }
        }

    }
}
