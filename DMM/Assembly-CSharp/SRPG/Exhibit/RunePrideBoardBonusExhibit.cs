// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideBoardBonusExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034CF")]
  public class RunePrideBoardBonusExhibit : 
    BaseExhibit,
    IRenderModel<RunePrideBoardBonusModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA9B")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideBoardBonusExhibit.EKey), typeof (RunePrideBoardBonusExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA24")]
    [Address(RVA = "0xAF2680", Offset = "0xAF1480", VA = "0x10AF2680", Slot = "8")]
    public void Render(RunePrideBoardBonusModel _model)
    {
    }

    [Token(Token = "0x600EA25")]
    [Address(RVA = "0xAF2930", Offset = "0xAF1730", VA = "0x10AF2930")]
    private void SetTargetAcitve(MonoBehaviour _target, bool _active)
    {
    }

    [Token(Token = "0x600EA26")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideBoardBonusExhibit()
    {
    }

    [Token(Token = "0x20034D0")]
    private enum EKey
    {
      [Token(Token = "0x400FA9D")] None,
      [Token(Token = "0x400FA9E")] BonusObj,
      [Token(Token = "0x400FA9F")] BonusImage,
      [Token(Token = "0x400FAA0")] BonusNum,
      [Token(Token = "0x400FAA1")] BonusAnim,
      [Token(Token = "0x400FAA2")] ButtonEnable,
      [Token(Token = "0x400FAA3")] SelectObj,
      [Token(Token = "0x400FAA4")] ParameterTextObj,
      [Token(Token = "0x400FAA5")] PotentialTextObj,
      [Token(Token = "0x400FAA6")] IsMask,
    }
  }
}
