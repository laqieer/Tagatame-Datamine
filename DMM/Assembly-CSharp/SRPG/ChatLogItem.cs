// Decompiled with JetBrains decompiler
// Type: SRPG.ChatLogItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002158")]
  [AddComponentMenu("UI/ChatLogItem")]
  public class ChatLogItem : MonoBehaviour
  {
    [Token(Token = "0x4009151")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_Button LeftIconRoot;
    [Token(Token = "0x4009152")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SRPG_Button RightIconRoot;
    [Token(Token = "0x4009153")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RawImage LeftIcon;
    [Token(Token = "0x4009154")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage RightIcon;
    [Token(Token = "0x4009155")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject MessageRoot;
    [Token(Token = "0x4009156")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image LeftMessageBgImage;
    [Token(Token = "0x4009157")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Image RightMessageBgImage;
    [Token(Token = "0x4009158")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject LeftMessageStatus;
    [Token(Token = "0x4009159")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject RightMessageStatus;
    [Token(Token = "0x400915A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text LeftMessageTextObj;
    [Token(Token = "0x400915B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text RightMessageTextObj;
    [Token(Token = "0x400915C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject LeftStampObj;
    [Token(Token = "0x400915D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject RightStampObj;
    [Token(Token = "0x400915E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text RightNameObj;
    [Token(Token = "0x400915F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text RightFuIDObj;
    [Token(Token = "0x4009160")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text RightPostAtObj;
    [Token(Token = "0x4009161")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Image RightStampImageObj;
    [Token(Token = "0x4009162")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text LeftNameObj;
    [Token(Token = "0x4009163")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text LeftFuIDObj;
    [Token(Token = "0x4009164")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text LeftPostAtObj;
    [Token(Token = "0x4009165")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Image LeftStampImageObj;
    [Token(Token = "0x4009166")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject SystemMessageRootObj;
    [Token(Token = "0x4009167")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text SystemMessageTextObj;
    [Token(Token = "0x4009168")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text SystemPostAtObj;
    [Token(Token = "0x4009169")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Button GuildInviteButton;
    [Token(Token = "0x400916A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text GuildInviteMessage;
    [Token(Token = "0x400916B")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject GuildRaidPartyParent;
    [Token(Token = "0x400916C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text GuildRaidPartyMessage;
    [Token(Token = "0x400916D")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private GameObject OfficialMessageRootObj;
    [Token(Token = "0x400916E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text OfficialMessageTitleObj;
    [Token(Token = "0x400916F")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private Text OfficialMessageTextObj;
    [Token(Token = "0x4009170")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private WebHelpButton OfficialJumpURLObj;
    [Token(Token = "0x4009171")]
    [FieldOffset(Offset = "0x8C")]
    private ChatStampParam[] mStampParams;
    [Token(Token = "0x4009172")]
    [FieldOffset(Offset = "0x90")]
    private bool IsStampSettings;
    [Token(Token = "0x4009173")]
    [FieldOffset(Offset = "0x94")]
    private Coroutine mCoroutine;
    [Token(Token = "0x4009174")]
    [FieldOffset(Offset = "0x98")]
    private ChatLogParam mChatLogParam;
    [Token(Token = "0x4009175")]
    [FieldOffset(Offset = "0x9C")]
    public readonly int STAMP_SIZE;

    [Token(Token = "0x170013C3")]
    public ChatLogParam ChatLogParam
    {
      [Token(Token = "0x6008C0D"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (ChatLogParam) null;
      }
    }

    [Token(Token = "0x6008C0E")]
    [Address(RVA = "0x4FCC40", Offset = "0x4FBA40", VA = "0x104FCC40")]
    public void Awake()
    {
    }

    [Token(Token = "0x6008C0F")]
    [Address(RVA = "0x4FF700", Offset = "0x4FE500", VA = "0x104FF700")]
    private void Start()
    {
    }

    [Token(Token = "0x6008C10")]
    [Address(RVA = "0x4FD260", Offset = "0x4FC060", VA = "0x104FD260")]
    public void OnDisable()
    {
    }

    [Token(Token = "0x6008C11")]
    [Address(RVA = "0x4FCCB0", Offset = "0x4FBAB0", VA = "0x104FCCB0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6008C12")]
    [Address(RVA = "0x4FD950", Offset = "0x4FC750", VA = "0x104FD950")]
    public void SetParam(ChatLogParam param, SRPG_Button.ButtonClickEvent OnClickEvent)
    {
    }

    [Token(Token = "0x6008C13")]
    [Address(RVA = "0x4FD580", Offset = "0x4FC380", VA = "0x104FD580")]
    private void RefreshView(ChatWindow.MessageTemplateType view_type, ChatLogParam chat_param)
    {
    }

    [Token(Token = "0x6008C14")]
    [Address(RVA = "0x4FCDA0", Offset = "0x4FBBA0", VA = "0x104FCDA0")]
    private void DisableAll()
    {
    }

    [Token(Token = "0x6008C15")]
    [Address(RVA = "0x4FE950", Offset = "0x4FD750", VA = "0x104FE950")]
    private void Setup_Other(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C16")]
    [Address(RVA = "0x4FF2A0", Offset = "0x4FE0A0", VA = "0x104FF2A0")]
    private void Setup_Self(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C17")]
    [Address(RVA = "0x4FF320", Offset = "0x4FE120", VA = "0x104FF320")]
    private void Setup_SystemMessage(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C18")]
    [Address(RVA = "0x4FDF80", Offset = "0x4FCD80", VA = "0x104FDF80")]
    private void Setup_OfficialMessage(ChatLogOfficialParam param)
    {
    }

    [Token(Token = "0x6008C19")]
    [Address(RVA = "0x4FE4F0", Offset = "0x4FD2F0", VA = "0x104FE4F0")]
    private void Setup_OtherMessage(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C1A")]
    [Address(RVA = "0x4FEE40", Offset = "0x4FDC40", VA = "0x104FEE40")]
    private void Setup_SelfMessage(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C1B")]
    [Address(RVA = "0x4FE720", Offset = "0x4FD520", VA = "0x104FE720")]
    private void Setup_OtherStamp(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C1C")]
    [Address(RVA = "0x4FF070", Offset = "0x4FDE70", VA = "0x104FF070")]
    private void Setup_SelfStamp(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C1D")]
    [Address(RVA = "0x4FE080", Offset = "0x4FCE80", VA = "0x104FE080")]
    private void Setup_OtherGuildInvite(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C1E")]
    [Address(RVA = "0x4FE9D0", Offset = "0x4FD7D0", VA = "0x104FE9D0")]
    private void Setup_SelfGuildInvite(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C1F")]
    [Address(RVA = "0x4FE2C0", Offset = "0x4FD0C0", VA = "0x104FE2C0")]
    private void Setup_OtherGuildRaidReport(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C20")]
    [Address(RVA = "0x4FEC10", Offset = "0x4FDA10", VA = "0x104FEC10")]
    private void Setup_SelfGuildRaidReport(ChatLogParam param)
    {
    }

    [Token(Token = "0x6008C21")]
    [Address(RVA = "0x4FF470", Offset = "0x4FE270", VA = "0x104FF470")]
    private void Setup_UnitIcon(ChatLogParam param, RawImage icon)
    {
    }

    [Token(Token = "0x6008C22")]
    [Address(RVA = "0x4FD810", Offset = "0x4FC610", VA = "0x104FD810")]
    public void Refresh(ChatLogParam param, ChatWindow.MessageTemplateType type)
    {
    }

    [Token(Token = "0x6008C23")]
    [Address(RVA = "0x4FCEA0", Offset = "0x4FBCA0", VA = "0x104FCEA0")]
    public static string GetPostAt(long postat) => (string) null;

    [Token(Token = "0x6008C24")]
    [Address(RVA = "0x4FD4E0", Offset = "0x4FC2E0", VA = "0x104FD4E0")]
    private IEnumerator RefreshTextLine(
      string text,
      Text text_obj,
      Image image_bg,
      bool is_use_richtext = false,
      string url = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008C25")]
    [Address(RVA = "0x4FD320", Offset = "0x4FC120", VA = "0x104FD320")]
    private IEnumerator RefreshInviteTextLine(
      long guild_id,
      string guild_name,
      int lower_lv,
      bool is_auto_approval,
      string text,
      string emblem,
      int policy)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008C26")]
    [Address(RVA = "0x4FD3D0", Offset = "0x4FC1D0", VA = "0x104FD3D0")]
    private IEnumerator RefreshOfficialTextLine(string title, string body, string url)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008C27")]
    [Address(RVA = "0x4FD2A0", Offset = "0x4FC0A0", VA = "0x104FD2A0")]
    private IEnumerator RefreshGuildRaidPartyTextLine(string text, int report_id)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008C28")]
    [Address(RVA = "0x4FD460", Offset = "0x4FC260", VA = "0x104FD460")]
    private IEnumerator RefreshStamp(int id, Image target_image) => (IEnumerator) null;

    [Token(Token = "0x6008C29")]
    [Address(RVA = "0x4FDCE0", Offset = "0x4FCAE0", VA = "0x104FDCE0")]
    private bool SetupChatStampMaster() => new bool();

    [Token(Token = "0x6008C2A")]
    [Address(RVA = "0x4FF720", Offset = "0x4FE520", VA = "0x104FF720")]
    public ChatLogItem()
    {
    }

    [Token(Token = "0x2002159")]
    private class OfficialChatUrlJump : MonoBehaviour, IWebHelp
    {
      [Token(Token = "0x4009176")]
      [FieldOffset(Offset = "0xC")]
      private string URL;
      [Token(Token = "0x4009177")]
      [FieldOffset(Offset = "0x10")]
      private string Title;

      [Token(Token = "0x6008C2B")]
      [Address(RVA = "0x50A210", Offset = "0x509010", VA = "0x1050A210")]
      public void Setup(string url, string title)
      {
      }

      [Token(Token = "0x6008C2C")]
      [Address(RVA = "0x50A1E0", Offset = "0x508FE0", VA = "0x1050A1E0", Slot = "4")]
      public bool GetHelpURL(out string url, out string title) => new bool();

      [Token(Token = "0x6008C2D")]
      [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
      public OfficialChatUrlJump()
      {
      }
    }
  }
}
