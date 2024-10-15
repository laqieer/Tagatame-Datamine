// Decompiled with JetBrains decompiler
// Type: SRPG.ChatTemplateMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002167")]
  [AddComponentMenu("UI/ChatTemplateMessage")]
  public class ChatTemplateMessage : MonoBehaviour
  {
    [Token(Token = "0x40091C7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_Button[] template_message_buttons;
    [Token(Token = "0x40091C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ChatWindow chat_window;
    [Token(Token = "0x40091C9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button next_page_button;
    [Token(Token = "0x40091CA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button back_page_button;
    [Token(Token = "0x40091CB")]
    [FieldOffset(Offset = "0x1C")]
    private ChatUtility.Json_ChatTemplateData prefs_data;
    [Token(Token = "0x40091CC")]
    [FieldOffset(Offset = "0x20")]
    private int ONE_PAGE_ITEM_MAX;
    [Token(Token = "0x40091CD")]
    [FieldOffset(Offset = "0x24")]
    private int LAST_PAGE;
    [Token(Token = "0x40091CE")]
    [FieldOffset(Offset = "0x28")]
    private int current_page;

    [Token(Token = "0x6008C70")]
    [Address(RVA = "0x5013F0", Offset = "0x5001F0", VA = "0x105013F0")]
    public void LoadTemplateMessage()
    {
    }

    [Token(Token = "0x6008C71")]
    [Address(RVA = "0x501310", Offset = "0x500110", VA = "0x10501310")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008C72")]
    [Address(RVA = "0x5015B0", Offset = "0x5003B0", VA = "0x105015B0")]
    private void SetupButtons()
    {
    }

    [Token(Token = "0x6008C73")]
    [Address(RVA = "0x501910", Offset = "0x500710", VA = "0x10501910")]
    private void SetupPageButton()
    {
    }

    [Token(Token = "0x6008C74")]
    [Address(RVA = "0x5014A0", Offset = "0x5002A0", VA = "0x105014A0")]
    private void OnTapTemplateMessage(int msg_index)
    {
    }

    [Token(Token = "0x6008C75")]
    [Address(RVA = "0x501580", Offset = "0x500380", VA = "0x10501580")]
    private void PageNext()
    {
    }

    [Token(Token = "0x6008C76")]
    [Address(RVA = "0x501550", Offset = "0x500350", VA = "0x10501550")]
    private void PageBack()
    {
    }

    [Token(Token = "0x6008C77")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChatTemplateMessage()
    {
    }
  }
}
