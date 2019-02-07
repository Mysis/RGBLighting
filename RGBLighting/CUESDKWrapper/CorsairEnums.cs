﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBLighting.CUESDKWrapper {
    public enum CorsairDeviceType {
        CDT_Unknown = 0,
        CDT_Mouse = 1,
        CDT_Keyboard = 2,
        CDT_Headset = 3,
        CDT_MouseMat = 4,
        CDT_HeadsetStand = 5,
        CDT_CommanderPro = 6,
        CDT_LightingNodePro = 7
    }

    public enum CorsairPhysicalLayout {
        CPL_Invalid = 0,        // dummy value

        CPL_US = 1,
        CPL_UK = 2,
        CPL_BR = 3,
        CPL_JP = 4,
        CPL_KR = 5,             // valid values for keyboard

        CPL_Zones1 = 6,
        CPL_Zones2 = 7,
        CPL_Zones3 = 8,
        CPL_Zones4 = 9          // valid values for mouse
    }

    public enum CorsairLogicalLayout {
        CLL_Invalid = 0,        // dummy value
        CLL_US_Int = 1,
        CLL_NA = 2,
        CLL_EU = 3,
        CLL_UK = 4,
        CLL_BE = 5,
        CLL_BR = 6,
        CLL_CH = 7,
        CLL_CN = 8,
        CLL_DE = 9,
        CLL_ES = 10,
        CLL_FR = 11,
        CLL_IT = 12,
        CLL_ND = 13,
        CLL_RU = 14,
        CLL_JP = 15,
        CLL_KR = 16,
        CLL_TW = 17,
        CLL_MEX = 18
    }

    public enum CorsairDeviceCaps {
        CDC_None = 0,               // for devices that do not support any SDK functions
        CDC_Lighting = 1            // for devices that has controlled lighting
    }

    public enum CorsairAccessMode {
        CAM_ExclusiveLightingControl = 0
    }

    public enum CorsairError {
        CE_Success,                     // if previously called function completed successfully
        CE_ServerNotFound,              // CUE is not running or was shut down or third-party control is disabled in CUE settings(runtime error)
        CE_NoControl,                   // if some other client has or took over exclusive control (runtime error)
        CE_ProtocolHandshakeMissing,    // if developer did not perform protocol handshake(developer error)
        CE_IncompatibleProtocol,        // if developer is calling the function that is not supported by the server(either because protocol has broken by server or client or because the function is new and server is too old. Check CorsairProtocolDetails for details) (developer error)
        CE_InvalidArguments,            // if developer supplied invalid arguments to the function(for specifics look at function descriptions). (developer error)
    }

    public enum CorsairChannelDeviceType {
        CCDT_Invalid = 0,   // dummy value
        CCDT_HD_Fan = 1,
        CCDT_SP_Fan = 2,
        CCDT_LL_Fan = 3,
        CCDT_ML_Fan = 4,
        CCDT_Strip = 5,
        CCDT_DAP = 6
    }

    public enum CorsairKeyId {
        CorsairKey_Invalid = 0,

        CorsairKeyKb_G1 = 1,
        CorsairKeyKb_G2 = 2,
        CorsairKeyKb_G3 = 3,
        CorsairKeyKb_G4 = 4,
        CorsairKeyKb_G5 = 5,
        CorsairKeyKb_G6 = 6,
        CorsairKeyKb_G7 = 7,
        CorsairKeyKb_G8 = 8,
        CorsairKeyKb_G9 = 9,
        CorsairKeyKb_G10 = 10,
        CorsairKeyKb_G11 = 11,
        CorsairKeyKb_G12 = 12,
        CorsairKeyKb_G13 = 13,
        CorsairKeyKb_G14 = 14,
        CorsairKeyKb_G15 = 15,
        CorsairKeyKb_G16 = 16,
        CorsairKeyKb_G17 = 17,
        CorsairKeyKb_G18 = 18,

        CorsairKeyMouse_M1 = 19,
        CorsairKeyMouse_M2 = 20,
        CorsairKeyMouse_M3 = 21,
        CorsairKeyMouse_M4 = 22,
        CorsairKeyMouse_M5 = 23,
        CorsairKeyMouse_M6 = 24,
        CorsairKeyMouse_M7 = 25,
        CorsairKeyMouse_M8 = 26,
        CorsairKeyMouse_M9 = 27,
        CorsairKeyMouse_M10 = 28,
        CorsairKeyMouse_M11 = 29,
        CorsairKeyMouse_M12 = 30,

        CorsairKey_Last = CorsairKeyMouse_M12
    }

    public enum CorsairLedId {
        CLI_Invalid = 0,
        CLK_Escape = 1,
        CLK_F1 = 2,
        CLK_F2 = 3,
        CLK_F3 = 4,
        CLK_F4 = 5,
        CLK_F5 = 6,
        CLK_F6 = 7,
        CLK_F7 = 8,
        CLK_F8 = 9,
        CLK_F9 = 10,
        CLK_F10 = 11,
        CLK_F11 = 12,
        CLK_GraveAccentAndTilde = 13,
        CLK_1 = 14,
        CLK_2 = 15,
        CLK_3 = 16,
        CLK_4 = 17,
        CLK_5 = 18,
        CLK_6 = 19,
        CLK_7 = 20,
        CLK_8 = 21,
        CLK_9 = 22,
        CLK_0 = 23,
        CLK_MinusAndUnderscore = 24,
        CLK_Tab = 25,
        CLK_Q = 26,
        CLK_W = 27,
        CLK_E = 28,
        CLK_R = 29,
        CLK_T = 30,
        CLK_Y = 31,
        CLK_U = 32,
        CLK_I = 33,
        CLK_O = 34,
        CLK_P = 35,
        CLK_BracketLeft = 36,
        CLK_CapsLock = 37,
        CLK_A = 38,
        CLK_S = 39,
        CLK_D = 40,
        CLK_F = 41,
        CLK_G = 42,
        CLK_H = 43,
        CLK_J = 44,
        CLK_K = 45,
        CLK_L = 46,
        CLK_SemicolonAndColon = 47,
        CLK_ApostropheAndDoubleQuote = 48,
        CLK_LeftShift = 49,
        CLK_NonUsBackslash = 50,
        CLK_Z = 51,
        CLK_X = 52,
        CLK_C = 53,
        CLK_V = 54,
        CLK_B = 55,
        CLK_N = 56,
        CLK_M = 57,
        CLK_CommaAndLessThan = 58,
        CLK_PeriodAndBiggerThan = 59,
        CLK_SlashAndQuestionMark = 60,
        CLK_LeftCtrl = 61,
        CLK_LeftGui = 62,
        CLK_LeftAlt = 63,
        CLK_Lang2 = 64,
        CLK_Space = 65,
        CLK_Lang1 = 66,
        CLK_International2 = 67,
        CLK_RightAlt = 68,
        CLK_RightGui = 69,
        CLK_Application = 70,
        CLK_LedProgramming = 71,
        CLK_Brightness = 72,
        CLK_F12 = 73,
        CLK_PrintScreen = 74,
        CLK_ScrollLock = 75,
        CLK_PauseBreak = 76,
        CLK_Insert = 77,
        CLK_Home = 78,
        CLK_PageUp = 79,
        CLK_BracketRight = 80,
        CLK_Backslash = 81,
        CLK_NonUsTilde = 82,
        CLK_Enter = 83,
        CLK_International1 = 84,
        CLK_EqualsAndPlus = 85,
        CLK_International3 = 86,
        CLK_Backspace = 87,
        CLK_Delete = 88,
        CLK_End = 89,
        CLK_PageDown = 90,
        CLK_RightShift = 91,
        CLK_RightCtrl = 92,
        CLK_UpArrow = 93,
        CLK_LeftArrow = 94,
        CLK_DownArrow = 95,
        CLK_RightArrow = 96,
        CLK_WinLock = 97,
        CLK_Mute = 98,
        CLK_Stop = 99,
        CLK_ScanPreviousTrack = 100,
        CLK_PlayPause = 101,
        CLK_ScanNextTrack = 102,
        CLK_NumLock = 103,
        CLK_KeypadSlash = 104,
        CLK_KeypadAsterisk = 105,
        CLK_KeypadMinus = 106,
        CLK_KeypadPlus = 107,
        CLK_KeypadEnter = 108,
        CLK_Keypad7 = 109,
        CLK_Keypad8 = 110,
        CLK_Keypad9 = 111,
        CLK_KeypadComma = 112,
        CLK_Keypad4 = 113,
        CLK_Keypad5 = 114,
        CLK_Keypad6 = 115,
        CLK_Keypad1 = 116,
        CLK_Keypad2 = 117,
        CLK_Keypad3 = 118,
        CLK_Keypad0 = 119,
        CLK_KeypadPeriodAndDelete = 120,
        CLK_G1 = 121,
        CLK_G2 = 122,
        CLK_G3 = 123,
        CLK_G4 = 124,
        CLK_G5 = 125,
        CLK_G6 = 126,
        CLK_G7 = 127,
        CLK_G8 = 128,
        CLK_G9 = 129,
        CLK_G10 = 130,
        CLK_VolumeUp = 131,
        CLK_VolumeDown = 132,
        CLK_MR = 133,
        CLK_M1 = 134,
        CLK_M2 = 135,
        CLK_M3 = 136,
        CLK_G11 = 137,
        CLK_G12 = 138,
        CLK_G13 = 139,
        CLK_G14 = 140,
        CLK_G15 = 141,
        CLK_G16 = 142,
        CLK_G17 = 143,
        CLK_G18 = 144,
        CLK_International5 = 145,
        CLK_International4 = 146,
        CLK_Fn = 147,

        CLM_1 = 148,
        CLM_2 = 149,
        CLM_3 = 150,
        CLM_4 = 151,

        CLH_LeftLogo = 152,
        CLH_RightLogo = 153,

        CLK_Logo = 154,

        CLMM_Zone1 = 155,
        CLMM_Zone2 = 156,
        CLMM_Zone3 = 157,
        CLMM_Zone4 = 158,
        CLMM_Zone5 = 159,
        CLMM_Zone6 = 160,
        CLMM_Zone7 = 161,
        CLMM_Zone8 = 162,
        CLMM_Zone9 = 163,
        CLMM_Zone10 = 164,
        CLMM_Zone11 = 165,
        CLMM_Zone12 = 166,
        CLMM_Zone13 = 167,
        CLMM_Zone14 = 168,
        CLMM_Zone15 = 169,

        CLKLP_Zone1 = 170,
        CLKLP_Zone2 = 171,
        CLKLP_Zone3 = 172,
        CLKLP_Zone4 = 173,
        CLKLP_Zone5 = 174,
        CLKLP_Zone6 = 175,
        CLKLP_Zone7 = 176,
        CLKLP_Zone8 = 177,
        CLKLP_Zone9 = 178,
        CLKLP_Zone10 = 179,
        CLKLP_Zone11 = 180,
        CLKLP_Zone12 = 181,
        CLKLP_Zone13 = 182,
        CLKLP_Zone14 = 183,
        CLKLP_Zone15 = 184,
        CLKLP_Zone16 = 185,
        CLKLP_Zone17 = 186,
        CLKLP_Zone18 = 187,
        CLKLP_Zone19 = 188,

        CLM_5 = 189,
        CLM_6 = 190,

        CLHSS_Zone1 = 191,
        CLHSS_Zone2 = 192,
        CLHSS_Zone3 = 193,
        CLHSS_Zone4 = 194,
        CLHSS_Zone5 = 195,
        CLHSS_Zone6 = 196,
        CLHSS_Zone7 = 197,
        CLHSS_Zone8 = 198,
        CLHSS_Zone9 = 199,

        CLD_C1_1 = 200,
        CLD_C1_2 = 201,
        CLD_C1_3 = 202,
        CLD_C1_4 = 203,
        CLD_C1_5 = 204,
        CLD_C1_6 = 205,
        CLD_C1_7 = 206,
        CLD_C1_8 = 207,
        CLD_C1_9 = 208,
        CLD_C1_10 = 209,
        CLD_C1_11 = 210,
        CLD_C1_12 = 211,
        CLD_C1_13 = 212,
        CLD_C1_14 = 213,
        CLD_C1_15 = 214,
        CLD_C1_16 = 215,
        CLD_C1_17 = 216,
        CLD_C1_18 = 217,
        CLD_C1_19 = 218,
        CLD_C1_20 = 219,
        CLD_C1_21 = 220,
        CLD_C1_22 = 221,
        CLD_C1_23 = 222,
        CLD_C1_24 = 223,
        CLD_C1_25 = 224,
        CLD_C1_26 = 225,
        CLD_C1_27 = 226,
        CLD_C1_28 = 227,
        CLD_C1_29 = 228,
        CLD_C1_30 = 229,
        CLD_C1_31 = 230,
        CLD_C1_32 = 231,
        CLD_C1_33 = 232,
        CLD_C1_34 = 233,
        CLD_C1_35 = 234,
        CLD_C1_36 = 235,
        CLD_C1_37 = 236,
        CLD_C1_38 = 237,
        CLD_C1_39 = 238,
        CLD_C1_40 = 239,
        CLD_C1_41 = 240,
        CLD_C1_42 = 241,
        CLD_C1_43 = 242,
        CLD_C1_44 = 243,
        CLD_C1_45 = 244,
        CLD_C1_46 = 245,
        CLD_C1_47 = 246,
        CLD_C1_48 = 247,
        CLD_C1_49 = 248,
        CLD_C1_50 = 249,
        CLD_C1_51 = 250,
        CLD_C1_52 = 251,
        CLD_C1_53 = 252,
        CLD_C1_54 = 253,
        CLD_C1_55 = 254,
        CLD_C1_56 = 255,
        CLD_C1_57 = 256,
        CLD_C1_58 = 257,
        CLD_C1_59 = 258,
        CLD_C1_60 = 259,
        CLD_C1_61 = 260,
        CLD_C1_62 = 261,
        CLD_C1_63 = 262,
        CLD_C1_64 = 263,
        CLD_C1_65 = 264,
        CLD_C1_66 = 265,
        CLD_C1_67 = 266,
        CLD_C1_68 = 267,
        CLD_C1_69 = 268,
        CLD_C1_70 = 269,
        CLD_C1_71 = 270,
        CLD_C1_72 = 271,
        CLD_C1_73 = 272,
        CLD_C1_74 = 273,
        CLD_C1_75 = 274,
        CLD_C1_76 = 275,
        CLD_C1_77 = 276,
        CLD_C1_78 = 277,
        CLD_C1_79 = 278,
        CLD_C1_80 = 279,
        CLD_C1_81 = 280,
        CLD_C1_82 = 281,
        CLD_C1_83 = 282,
        CLD_C1_84 = 283,
        CLD_C1_85 = 284,
        CLD_C1_86 = 285,
        CLD_C1_87 = 286,
        CLD_C1_88 = 287,
        CLD_C1_89 = 288,
        CLD_C1_90 = 289,
        CLD_C1_91 = 290,
        CLD_C1_92 = 291,
        CLD_C1_93 = 292,
        CLD_C1_94 = 293,
        CLD_C1_95 = 294,
        CLD_C1_96 = 295,
        CLD_C1_97 = 296,
        CLD_C1_98 = 297,
        CLD_C1_99 = 298,
        CLD_C1_100 = 299,
        CLD_C1_101 = 300,
        CLD_C1_102 = 301,
        CLD_C1_103 = 302,
        CLD_C1_104 = 303,
        CLD_C1_105 = 304,
        CLD_C1_106 = 305,
        CLD_C1_107 = 306,
        CLD_C1_108 = 307,
        CLD_C1_109 = 308,
        CLD_C1_110 = 309,
        CLD_C1_111 = 310,
        CLD_C1_112 = 311,
        CLD_C1_113 = 312,
        CLD_C1_114 = 313,
        CLD_C1_115 = 314,
        CLD_C1_116 = 315,
        CLD_C1_117 = 316,
        CLD_C1_118 = 317,
        CLD_C1_119 = 318,
        CLD_C1_120 = 319,
        CLD_C1_121 = 320,
        CLD_C1_122 = 321,
        CLD_C1_123 = 322,
        CLD_C1_124 = 323,
        CLD_C1_125 = 324,
        CLD_C1_126 = 325,
        CLD_C1_127 = 326,
        CLD_C1_128 = 327,
        CLD_C1_129 = 328,
        CLD_C1_130 = 329,
        CLD_C1_131 = 330,
        CLD_C1_132 = 331,
        CLD_C1_133 = 332,
        CLD_C1_134 = 333,
        CLD_C1_135 = 334,
        CLD_C1_136 = 335,
        CLD_C1_137 = 336,
        CLD_C1_138 = 337,
        CLD_C1_139 = 338,
        CLD_C1_140 = 339,
        CLD_C1_141 = 340,
        CLD_C1_142 = 341,
        CLD_C1_143 = 342,
        CLD_C1_144 = 343,
        CLD_C1_145 = 344,
        CLD_C1_146 = 345,
        CLD_C1_147 = 346,
        CLD_C1_148 = 347,
        CLD_C1_149 = 348,
        CLD_C1_150 = 349,

        CLD_C2_1 = 350,
        CLD_C2_2 = 351,
        CLD_C2_3 = 352,
        CLD_C2_4 = 353,
        CLD_C2_5 = 354,
        CLD_C2_6 = 355,
        CLD_C2_7 = 356,
        CLD_C2_8 = 357,
        CLD_C2_9 = 358,
        CLD_C2_10 = 359,
        CLD_C2_11 = 360,
        CLD_C2_12 = 361,
        CLD_C2_13 = 362,
        CLD_C2_14 = 363,
        CLD_C2_15 = 364,
        CLD_C2_16 = 365,
        CLD_C2_17 = 366,
        CLD_C2_18 = 367,
        CLD_C2_19 = 368,
        CLD_C2_20 = 369,
        CLD_C2_21 = 370,
        CLD_C2_22 = 371,
        CLD_C2_23 = 372,
        CLD_C2_24 = 373,
        CLD_C2_25 = 374,
        CLD_C2_26 = 375,
        CLD_C2_27 = 376,
        CLD_C2_28 = 377,
        CLD_C2_29 = 378,
        CLD_C2_30 = 379,
        CLD_C2_31 = 380,
        CLD_C2_32 = 381,
        CLD_C2_33 = 382,
        CLD_C2_34 = 383,
        CLD_C2_35 = 384,
        CLD_C2_36 = 385,
        CLD_C2_37 = 386,
        CLD_C2_38 = 387,
        CLD_C2_39 = 388,
        CLD_C2_40 = 389,
        CLD_C2_41 = 390,
        CLD_C2_42 = 391,
        CLD_C2_43 = 392,
        CLD_C2_44 = 393,
        CLD_C2_45 = 394,
        CLD_C2_46 = 395,
        CLD_C2_47 = 396,
        CLD_C2_48 = 397,
        CLD_C2_49 = 398,
        CLD_C2_50 = 399,
        CLD_C2_51 = 400,
        CLD_C2_52 = 401,
        CLD_C2_53 = 402,
        CLD_C2_54 = 403,
        CLD_C2_55 = 404,
        CLD_C2_56 = 405,
        CLD_C2_57 = 406,
        CLD_C2_58 = 407,
        CLD_C2_59 = 408,
        CLD_C2_60 = 409,
        CLD_C2_61 = 410,
        CLD_C2_62 = 411,
        CLD_C2_63 = 412,
        CLD_C2_64 = 413,
        CLD_C2_65 = 414,
        CLD_C2_66 = 415,
        CLD_C2_67 = 416,
        CLD_C2_68 = 417,
        CLD_C2_69 = 418,
        CLD_C2_70 = 419,
        CLD_C2_71 = 420,
        CLD_C2_72 = 421,
        CLD_C2_73 = 422,
        CLD_C2_74 = 423,
        CLD_C2_75 = 424,
        CLD_C2_76 = 425,
        CLD_C2_77 = 426,
        CLD_C2_78 = 427,
        CLD_C2_79 = 428,
        CLD_C2_80 = 429,
        CLD_C2_81 = 430,
        CLD_C2_82 = 431,
        CLD_C2_83 = 432,
        CLD_C2_84 = 433,
        CLD_C2_85 = 434,
        CLD_C2_86 = 435,
        CLD_C2_87 = 436,
        CLD_C2_88 = 437,
        CLD_C2_89 = 438,
        CLD_C2_90 = 439,
        CLD_C2_91 = 440,
        CLD_C2_92 = 441,
        CLD_C2_93 = 442,
        CLD_C2_94 = 443,
        CLD_C2_95 = 444,
        CLD_C2_96 = 445,
        CLD_C2_97 = 446,
        CLD_C2_98 = 447,
        CLD_C2_99 = 448,
        CLD_C2_100 = 449,
        CLD_C2_101 = 450,
        CLD_C2_102 = 451,
        CLD_C2_103 = 452,
        CLD_C2_104 = 453,
        CLD_C2_105 = 454,
        CLD_C2_106 = 455,
        CLD_C2_107 = 456,
        CLD_C2_108 = 457,
        CLD_C2_109 = 458,
        CLD_C2_110 = 459,
        CLD_C2_111 = 460,
        CLD_C2_112 = 461,
        CLD_C2_113 = 462,
        CLD_C2_114 = 463,
        CLD_C2_115 = 464,
        CLD_C2_116 = 465,
        CLD_C2_117 = 466,
        CLD_C2_118 = 467,
        CLD_C2_119 = 468,
        CLD_C2_120 = 469,
        CLD_C2_121 = 470,
        CLD_C2_122 = 471,
        CLD_C2_123 = 472,
        CLD_C2_124 = 473,
        CLD_C2_125 = 474,
        CLD_C2_126 = 475,
        CLD_C2_127 = 476,
        CLD_C2_128 = 477,
        CLD_C2_129 = 478,
        CLD_C2_130 = 479,
        CLD_C2_131 = 480,
        CLD_C2_132 = 481,
        CLD_C2_133 = 482,
        CLD_C2_134 = 483,
        CLD_C2_135 = 484,
        CLD_C2_136 = 485,
        CLD_C2_137 = 486,
        CLD_C2_138 = 487,
        CLD_C2_139 = 488,
        CLD_C2_140 = 489,
        CLD_C2_141 = 490,
        CLD_C2_142 = 491,
        CLD_C2_143 = 492,
        CLD_C2_144 = 493,
        CLD_C2_145 = 494,
        CLD_C2_146 = 495,
        CLD_C2_147 = 496,
        CLD_C2_148 = 497,
        CLD_C2_149 = 498,
        CLD_C2_150 = 499,

        CLI_Last = CLD_C2_150
    }
}
