// Decompiled with JetBrains decompiler
// Type: SRPG.GuildMemberManagementItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002566")]
  [AddComponentMenu("UI/GuildMemberManagementItem")]
  public class GuildMemberManagementItem : MonoBehaviour
  {
    [Token(Token = "0x400ACB4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mKickButton;
    [Token(Token = "0x400ACB5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mChangeRoleButton;
    [Token(Token = "0x400ACB6")]
    [FieldOffset(Offset = "0x14")]
    private GuildMemberData mMemberData;

    [Token(Token = "0x600A58D")]
    [Address(RVA = "0x679430", Offset = "0x678230", VA = "0x10679430")]
    public void Init(GuildMemberData member_data)
    {
    }

    [Token(Token = "0x600A58E")]
    [Address(RVA = "0x679660", Offset = "0x678460", VA = "0x10679660")]
    private void SetupUI_Master()
    {
    }

    [Token(Token = "0x600A58F")]
    [Address(RVA = "0x679760", Offset = "0x678560", VA = "0x10679760")]
    private void SetupUI_SubMaster()
    {
    }

    [Token(Token = "0x600A590")]
    [Address(RVA = "0x679720", Offset = "0x678520", VA = "0x10679720")]
    private void SetupUI_Member()
    {
    }

    [Token(Token = "0x600A591")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildMemberManagementItem()
    {
    }
  }
}
