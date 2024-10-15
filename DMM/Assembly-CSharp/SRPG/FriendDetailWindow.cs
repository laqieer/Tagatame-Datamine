// Decompiled with JetBrains decompiler
// Type: SRPG.FriendDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D5")]
  [AddComponentMenu("")]
  public class FriendDetailWindow : MonoBehaviour
  {
    [Token(Token = "0x400A21A")]
    [FieldOffset(Offset = "0xC")]
    public string ToolTipPrefab;
    [Token(Token = "0x400A21B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mastery_release;
    [Token(Token = "0x400A21C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mastery_none;
    [Token(Token = "0x400A21D")]
    [FieldOffset(Offset = "0x18")]
    private SerializeValueList m_ValueList;
    [Token(Token = "0x400A21E")]
    [FieldOffset(Offset = "0x1C")]
    private FriendDetailWindow.Mode m_Mode;
    [Token(Token = "0x400A21F")]
    [FieldOffset(Offset = "0x20")]
    private FriendData m_FriendData;
    [Token(Token = "0x400A220")]
    [FieldOffset(Offset = "0x24")]
    private ChatPlayerData m_ChatPlayerData;
    [Token(Token = "0x400A221")]
    [FieldOffset(Offset = "0x28")]
    private SupportSettingRootWindow m_ElementWindow;
    [Token(Token = "0x400A222")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject m_ToolTip;

    [Token(Token = "0x6009BCD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009BCE")]
    [Address(RVA = "0x5F1F60", Offset = "0x5F0D60", VA = "0x105F1F60")]
    private void Setup(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6009BCF")]
    [Address(RVA = "0x5F1830", Offset = "0x5F0630", VA = "0x105F1830")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009BD0")]
    [Address(RVA = "0x5F1E40", Offset = "0x5F0C40", VA = "0x105F1E40")]
    private void SetFriendData(FriendData data)
    {
    }

    [Token(Token = "0x6009BD1")]
    [Address(RVA = "0x5F1DE0", Offset = "0x5F0BE0", VA = "0x105F1DE0")]
    public void SetChatPlayerData(ChatPlayerData data)
    {
    }

    [Token(Token = "0x6009BD2")]
    [Address(RVA = "0x5F0F80", Offset = "0x5EFD80", VA = "0x105F0F80")]
    public void Bind()
    {
    }

    [Token(Token = "0x6009BD3")]
    [Address(RVA = "0x5F16E0", Offset = "0x5F04E0", VA = "0x105F16E0")]
    public void OnEvent(string key, string value)
    {
    }

    [Token(Token = "0x6009BD4")]
    [Address(RVA = "0x5F1230", Offset = "0x5F0030", VA = "0x105F1230")]
    private void OnEvent_Open()
    {
    }

    [Token(Token = "0x6009BD5")]
    [Address(RVA = "0x5F1240", Offset = "0x5F0040", VA = "0x105F1240")]
    private void OnEvent_ToolTip()
    {
    }

    [Token(Token = "0x6009BD6")]
    [Address(RVA = "0x5F2350", Offset = "0x5F1150", VA = "0x105F2350")]
    public FriendDetailWindow()
    {
    }

    [Token(Token = "0x20023D6")]
    public enum Mode
    {
      [Token(Token = "0x400A224")] NONE,
      [Token(Token = "0x400A225")] DEFAULT,
      [Token(Token = "0x400A226")] NOTIFICATION,
      [Token(Token = "0x400A227")] SEARCH,
      [Token(Token = "0x400A228")] BLOCK,
      [Token(Token = "0x400A229")] CHAT,
      [Token(Token = "0x400A22A")] GUILD_MEMBER,
    }
  }
}
