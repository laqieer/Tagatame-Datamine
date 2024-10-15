// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RaidBossHealBpExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003495")]
  public class RaidBossHealBpExhibit : BaseExhibit, IRenderModel<RaidBossHealBpModel>, IRenderModel
  {
    [Token(Token = "0x400F99E")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RaidBossHealBpExhibit.EKey), typeof (RaidBossHealBpExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F99F")]
    [FieldOffset(Offset = "0x38")]
    public GameObject[] mBpList;
    [Token(Token = "0x400F9A0")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject[] mBpHealList;

    [Token(Token = "0x600E9CD")]
    [Address(RVA = "0xAEE660", Offset = "0xAED460", VA = "0x10AEE660", Slot = "8")]
    public void Render(RaidBossHealBpModel model)
    {
    }

    [Token(Token = "0x600E9CE")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RaidBossHealBpExhibit()
    {
    }

    [Token(Token = "0x2003496")]
    private enum EKey
    {
      [Token(Token = "0x400F9A2")] None,
      [Token(Token = "0x400F9A3")] TitleText,
      [Token(Token = "0x400F9A4")] BPDisp,
      [Token(Token = "0x400F9A5")] NeedCoin,
      [Token(Token = "0x400F9A6")] HaveFreeCoin,
      [Token(Token = "0x400F9A7")] HavePaidCoin,
    }
  }
}
