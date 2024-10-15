// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkTicketInfoWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020EA")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "実行", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/Bookmark/QuestBookmarkTicketInfoWindow")]
  public class QuestBookmarkTicketInfoWindow : MonoBehaviour
  {
    [Token(Token = "0x4008E3B")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008E3C")]
    private const int PIN_OUTPUT_OK = 101;
    [Token(Token = "0x4008E3D")]
    [FieldOffset(Offset = "0xC")]
    private readonly string QUEST_BOOK_MARK_INFO_AP_COMMENT;
    [Token(Token = "0x4008E3E")]
    [FieldOffset(Offset = "0x10")]
    private readonly string QUEST_BOOK_MARK_INFO_COMENT;
    [Token(Token = "0x4008E3F")]
    [FieldOffset(Offset = "0x14")]
    private readonly string QUEST_BOOK_MARK_INFO_COMMENT_CONJUNCTION;
    [Token(Token = "0x4008E40")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BitmapText UseAP;
    [Token(Token = "0x4008E41")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private BitmapText UseTicket;
    [Token(Token = "0x4008E42")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mComment;
    [Token(Token = "0x4008E43")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Color OverColor;
    [Token(Token = "0x4008E44")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Color LessColor;

    [Token(Token = "0x6008973")]
    [Address(RVA = "0x4B49D0", Offset = "0x4B37D0", VA = "0x104B49D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008974")]
    [Address(RVA = "0x4B49D0", Offset = "0x4B37D0", VA = "0x104B49D0")]
    private void Init()
    {
    }

    [Token(Token = "0x6008975")]
    [Address(RVA = "0x4B49E0", Offset = "0x4B37E0", VA = "0x104B49E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008976")]
    [Address(RVA = "0x4B4EC0", Offset = "0x4B3CC0", VA = "0x104B4EC0")]
    public QuestBookmarkTicketInfoWindow()
    {
    }
  }
}
