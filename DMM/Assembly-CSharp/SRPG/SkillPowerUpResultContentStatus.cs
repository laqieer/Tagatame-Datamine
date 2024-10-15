// Decompiled with JetBrains decompiler
// Type: SRPG.SkillPowerUpResultContentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AC8")]
  [AddComponentMenu("UI/SkillPowerUpResultContentStatus")]
  public class SkillPowerUpResultContentStatus : MonoBehaviour
  {
    [Token(Token = "0x400D0AA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text paramNameText;
    [Token(Token = "0x400D0AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text prevParamText;
    [Token(Token = "0x400D0AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text resultParamText;
    [Token(Token = "0x400D0AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text resultAddedParamText;
    [Token(Token = "0x400D0AE")]
    [FieldOffset(Offset = "0x1C")]
    private string mPercent;

    [Token(Token = "0x600C35B")]
    [Address(RVA = "0x8CAE50", Offset = "0x8C9C50", VA = "0x108CAE50")]
    public void SetData(SkillPowerUpResultContent.Param param, ParamTypes type, bool isScale)
    {
    }

    [Token(Token = "0x600C35C")]
    [Address(RVA = "0x8CB280", Offset = "0x8CA080", VA = "0x108CB280")]
    public void SetTokkoParameter(
      TokkouParam current,
      TokkouParam prev,
      TokkouParam currentBonus,
      TokkouParam prevBonus,
      ParamTypes type)
    {
    }

    [Token(Token = "0x600C35D")]
    [Address(RVA = "0x8CBB50", Offset = "0x8CA950", VA = "0x108CBB50")]
    public SkillPowerUpResultContentStatus()
    {
    }
  }
}
