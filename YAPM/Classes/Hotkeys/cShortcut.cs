﻿
public class cShortcut
{

    // ========================================
    // Public Enums
    // ========================================

    // Key list (according to GetAsyncKeyState parameters)
    public enum ShorcutKeys : int
    {
        VK_NO_BUTTON = -1,
        VK_LBUTTON = 0x1,
        VK_RBUTTON = 0x2,
        VK_CANCEL = 0x3,
        VK_MBUTTON = 0x4,
        VK_XBUTTON1 = 0x5,
        VK_XBUTTON2 = 0x6,
        VK_BACK = 0x8,
        VK_TAB = 0x9,
        VK_CLEAR = &H,
        VK_RETURN = 0xD,
        VK_SHIFT = 0x10,
        VK_CONTROL = 0x11,
        VK_MENU = 0x12,
        VK_PAUSE = 0x13,
        VK_CAPITAL = 0x14,
        VK_KANA = 0x15,
        VK_HANGUEL = 0x15,
        VK_HANGUL = 0x15,
        VK_JUNJA = 0x17,
        VK_FINAL = 0x18,
        VK_HANJA = 0x19,
        VK_KANJI = 0x19,
        VK_ESCAPE = 0x1B,
        VK_CONVERT = 0x1,
        VK_NONCONVERT = 0x1D,
        VK_ACCEPT = 0x1E,
        VK_MODECHANGE = 0x1F,
        VK_SPACE = 0x20,
        VK_PRIOR = 0x21,
        VK_NEXT = 0x22,
        VK_END = 0x23,
        VK_HOME = 0x24,
        VK_LEFT = 0x25,
        VK_UP = 0x26,
        VK_RIGHT = 0x27,
        VK_DOWN = 0x28,
        VK_SELECT = 0x29,
        VK_PRINT = 0x2A,
        VK_EXECUTE = 0x2B,
        VK_SNAPSHOT = 0x2,
        VK_INSERT = 0x2D,
        VK_DELETE = 0x2E,
        VK_HELP = 0x2F,
        VK_0 = 0x30,
        VK_1 = 0x31,
        VK_2 = 0x32,
        VK_3 = 0x33,
        VK_4 = 0x34,
        VK_5 = 0x35,
        VK_6 = 0x36,
        VK_7 = 0x37,
        VK_8 = 0x38,
        VK_9 = 0x39,
        VK_A = 0x41,
        VK_B = 0x42,
        VK_C = 0x43,
        VK_D = 0x44,
        VK_E = 0x45,
        VK_F = 0x46,
        VK_G = 0x47,
        VK_H = 0x48,
        VK_I = 0x49,
        VK_J = 0x4A,
        VK_K = 0x4B,
        VK_L = 0x4,
        VK_M = 0x4D,
        VK_N = 0x4E,
        VK_O = 0x4F,
        VK_P = 0x50,
        VK_Q = 0x51,
        VK_R = 0x52,
        VK_S = 0x53,
        VK_T = 0x54,
        VK_U = 0x55,
        VK_V = 0x56,
        VK_W = 0x57,
        VK_X = 0x58,
        VK_Y = 0x59,
        VK_Z = 0x5A,
        VK_LWIN = 0x5B,
        VK_RWIN = 0x5,
        VK_APPS = 0x5D,
        VK_SLEEP = 0x5F,
        VK_NUMPAD0 = 0x60,
        VK_NUMPAD1 = 0x61,
        VK_NUMPAD2 = 0x62,
        VK_NUMPAD3 = 0x63,
        VK_NUMPAD4 = 0x64,
        VK_NUMPAD5 = 0x65,
        VK_NUMPAD6 = 0x66,
        VK_NUMPAD7 = 0x67,
        VK_NUMPAD8 = 0x68,
        VK_NUMPAD9 = 0x69,
        VK_MULTIPLY = 0x6A,
        VK_ADD = 0x6B,
        VK_SEPARATOR = 0x6,
        VK_SUBTRACT = 0x6D,
        VK_DECIMAL = 0x6E,
        VK_DIVIDE = 0x6F,
        VK_F1 = 0x70,
        VK_F2 = 0x71,
        VK_F3 = 0x72,
        VK_F4 = 0x73,
        VK_F5 = 0x74,
        VK_F6 = 0x75,
        VK_F7 = 0x76,
        VK_F8 = 0x77,
        VK_F9 = 0x78,
        VK_F10 = 0x79,
        VK_F11 = 0x7A,
        VK_F12 = 0x7B,
        VK_F13 = 0x7,
        VK_F14 = 0x7D,
        VK_F15 = 0x7E,
        VK_F16 = 0x7F,
        VK_F17 = 0x80,
        VK_F18 = 0x81,
        VK_F19 = 0x82,
        VK_F20 = 0x83,
        VK_F21 = 0x84,
        VK_F22 = 0x85,
        VK_F23 = 0x86,
        VK_F24 = 0x87,
        VK_NUMLOCK = 0x90,
        VK_SCROLL = 0x91,
        VK_LSHIFT = 0xA0,
        VK_RSHIFT = 0xA1,
        VK_LCONTROL = 0xA2,
        VK_RCONTROL = 0xA3,
        VK_LMENU = 0xA4,
        VK_RMENU = 0xA5,
        VK_BROWSER_BACK = 0xA6,
        VK_BROWSER_FORWARD = 0xA7,
        VK_BROWSER_REFRESH = 0xA8,
        VK_BROWSER_STOP = 0xA9,
        VK_BROWSER_SEARCH = 0xAA,
        VK_BROWSER_FAVORITES = 0xAB,
        VK_BROWSER_HOME = 0xA,
        VK_VOLUME_MUTE = 0xAD,
        VK_VOLUME_DOWN = 0xAE,
        VK_VOLUME_UP = 0xAF,
        VK_MEDIA_NEXT_TRACK = 0xB0,
        VK_MEDIA_PREV_TRACK = 0xB1,
        VK_MEDIA_STOP = 0xB2,
        VK_MEDIA_PLAY_PAUSE = 0xB3,
        VK_LAUNCH_MAIL = 0xB4,
        VK_LAUNCH_MEDIA_SELECT = 0xB5,
        VK_LAUNCH_APP1 = 0xB6,
        VK_LAUNCH_APP2 = 0xB7,
        VK_OEM_1 = 0xBA,
        VK_OEM_PLUS = 0xBB,
        VK_OEM_COMMA = 0xB,
        VK_OEM_MINUS = 0xBD,
        VK_OEM_PERIOD = 0xBE,
        VK_OEM_2 = 0xBF,
        VK_OEM_3 = 0xC0,
        VK_OEM_4 = 0xDB,
        VK_OEM_5 = 0xD,
        VK_OEM_6 = 0xDD,
        VK_OEM_7 = 0xDE,
        VK_OEM_8 = 0xDF,
        VK_OEM_102 = 0xE2,
        VK_PROCESSKEY = 0xE5,
        VK_PACKET = 0xE7,
        VK_ATTN = 0xF6,
        VK_CRSEL = 0xF7,
        VK_EXSEL = 0xF8,
        VK_EREOF = 0xF9,
        VK_PLAY = 0xFA,
        VK_ZOOM = 0xFB,
        VK_NONAME = 0xF,
        VK_PA1 = 0xFD,
        VK_OEM_CLEAR = 0xFE
    }

    // Action to proceed when hotkeys pressed
    public enum HOTKEYS_ACTIONS : int
    {
        KILL_FOREGROUND = 1,
        EXIT_YAPM = 2
    }

    // ========================================
    // Private variables
    // ========================================
    private ShorcutKeys _Key1;
    private ShorcutKeys _Key2;
    private ShorcutKeys _Key3;
    private HOTKEYS_ACTIONS _action;
    private bool _enabled;
    private string _key;


    // ========================================
    // Public properties
    // ========================================
    public string Key
    {
        get
        {
            return _key;
        }
    }
    public bool Enabled
    {
        get
        {
            return _enabled;
        }
        set
        {
            _enabled = value;
        }
    }
    public ShorcutKeys Key1
    {
        get
        {
            return _Key1;
        }
        set
        {
            _Key1 = value;
        }
    }
    public HOTKEYS_ACTIONS Action
    {
        get
        {
            return _action;
        }
        set
        {
            _action = value;
        }
    }
    public ShorcutKeys Key2
    {
        get
        {
            return _Key2;
        }
        set
        {
            _Key2 = value;
        }
    }
    public ShorcutKeys Key3
    {
        get
        {
            return _Key3;
        }
        set
        {
            _Key3 = value;
        }
    }


    // ========================================
    // Public functions
    // ========================================
    public cShortcut(HOTKEYS_ACTIONS aAction, ShorcutKeys akey1, ShorcutKeys akey2 = ShorcutKeys.VK_NO_BUTTON, ShorcutKeys akey3 = ShorcutKeys.VK_NO_BUTTON)
    {
        _Key1 = akey1;
        _Key2 = akey2;
        _Key3 = akey3;
        _key = "|" + System.Convert.ToString(System.Convert.ToInt32(this.Key1)) + "|" + System.Convert.ToString(System.Convert.ToInt32(this.Key2)) + "|" + System.Convert.ToString(System.Convert.ToInt32(this.Key3));
        _action = aAction;
        _enabled = true;
    }
    public cShortcut(int aAction, int akey1, int akey2 = ShorcutKeys.VK_NO_BUTTON, int akey3 = ShorcutKeys.VK_NO_BUTTON)
    {
        _Key1 = (ShorcutKeys)akey1;
        _Key2 = (ShorcutKeys)akey2;
        _Key3 = (ShorcutKeys)akey3;
        _key = "|" + System.Convert.ToString(System.Convert.ToInt32(this.Key1)) + "|" + System.Convert.ToString(System.Convert.ToInt32(this.Key2)) + "|" + System.Convert.ToString(System.Convert.ToInt32(this.Key3));
        _action = (HOTKEYS_ACTIONS)aAction;
        _enabled = true;
    }

    // Proceed to action !
    public void RaiseAction()
    {
        ;/* Cannot convert LocalDeclarationStatementSyntax, System.NotSupportedException: StaticKeyword not supported!
   в ICSharpCode.CodeConverter.CSharp.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context)
   в ICSharpCode.CodeConverter.CSharp.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context)
   в ICSharpCode.CodeConverter.CSharp.CommonConversions.<ConvertModifiersCore>d__20.MoveNext()
   в System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
   в Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
   в ICSharpCode.CodeConverter.CSharp.CommonConversions.ConvertModifiers(IEnumerable`1 modifiers, TokenContext context, Boolean isVariableOrConst, Boolean isConstructor)
   в ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
   в Microsoft.CodeAnalysis.VisualBasic.Syntax.LocalDeclarationStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   в Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   в ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
   в ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

Input: 
        Static once As Boolean = False

 */
        once = !(once);

        if (once)
        {
            switch (_action)
            {
                case HOTKEYS_ACTIONS.KILL_FOREGROUND:
                    {
                        cProcess.LocalKill(cWindow.LocalGetForegroundAppProcessId());
                        break;
                    }

                case HOTKEYS_ACTIONS.EXIT_YAPM:
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}

