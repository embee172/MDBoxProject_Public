﻿namespace MDBoxProject
{
    sealed class Constants
    {
        public static int HOST_PORT = 8410;
        public static int MBOX_PORT = 7408;
        public static string[] GOTO_MAX =
        {
            "\x55\xaa\x00\x00\x13\x01" ,
            "\x00\x01\xff\xff\xff\xff\x00\x00\x00\x01\x00\x00\x00\x00\x00\x01" ,
            "\x86\xa0\x00\x01\x86\xa0\x00\x01\x86\xa0\x00\x01\x86\xa0\x00\x01" ,
            "\x86\xa0\x00\x01\x86\xa0\x00\x00\x00\x00\x00\x00"

        };

        public static string[] GOTO_MAX_10AXIS =
        {
            "\x55\xaa\x00\x00\x13\x01" ,
            "\x00\x02\xff\xff\xff\xff\x00\x00\x00\x01\x00\x00\x00\x00\x00\x01" ,
            "\x86\xa0\x00\x01\x86\xa0\x00\x01\x86\xa0\x00\x01\x86\xa0\x00\x01" ,
            "\x86\xa0\x00\x01\x86\xa0\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00" ,
            "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00"
        };

        public static string[] GOTO_ZERO =
        {
            "\x55\xaa\x00\x00\x13\x01" ,
            "\x00\x01\xff\xff\xff\xff\x00\x00\x00\x01\x00\x00\x00\x00\x00\x00" ,
            "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00" ,
            "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00"
        };

        public static string[] GO_TO_ZERO_10AXIS =
        {
            "\x55\xaa\x00\x00\x13\x01",
            "\x00\x02\xff\xff\xff\xff\x00\x00\x00\x01\x00\x00\x00\x00\x00\x00",
            "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
            "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
            "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00"
        };
    }
}
