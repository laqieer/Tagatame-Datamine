// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.WorldRaidHealBpWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003511")]
  public class WorldRaidHealBpWindowExhibit : 
    BaseExhibit,
    IRenderModel<WorldRaidHealBpWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FBEF")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (WorldRaidHealBpWindowExhibit.EKey), typeof (WorldRaidHealBpWindowExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FBF0")]
    [FieldOffset(Offset = "0x38")]
    public GameObject[] mBpList;
    [Token(Token = "0x400FBF1")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject[] mBpHealList;

    [Token(Token = "0x600EA8C")]
    [Address(RVA = "0xAFE770", Offset = "0xAFD570", VA = "0x10AFE770", Slot = "8")]
    public void Render(WorldRaidHealBpWindowModel _model)
    {
    }

    [Token(Token = "0x600EA8D")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public WorldRaidHealBpWindowExhibit()
    {
    }

    [Token(Token = "0x2003512")]
    private enum EKey
    {
      [Token(Token = "0x400FBF3")] None,
      [Token(Token = "0x400FBF4")] TopText,
      [Token(Token = "0x400FBF5")] BPDisp,
      [Token(Token = "0x400FBF6")] Slider,
      [Token(Token = "0x400FBF7")] NeedCoin,
      [Token(Token = "0x400FBF8")] DownButton,
      [Token(Token = "0x400FBF9")] UpButton,
      [Token(Token = "0x400FBFA")] EqualityCostDisp,
      [Token(Token = "0x400FBFB")] EqualityCostText,
      [Token(Token = "0x400FBFC")] NoEqualityCostDisp,
      [Token(Token = "0x400FBFD")] LimitDisp,
      [Token(Token = "0x400FBFE")] LimitText,
    }
  }
}
