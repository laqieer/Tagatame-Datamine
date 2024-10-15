// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneContinueReinforcementExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034B3")]
  public class RuneContinueReinforcementExhibit : 
    BaseExhibit,
    IRenderModel<RuneContinueReinforcementModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA30")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneContinueReinforcementExhibit.EKey), typeof (RuneContinueReinforcementExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA01")]
    [Address(RVA = "0xAEFA70", Offset = "0xAEE870", VA = "0x10AEFA70", Slot = "8")]
    public void Render(RuneContinueReinforcementModel model)
    {
    }

    [Token(Token = "0x600EA02")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneContinueReinforcementExhibit()
    {
    }

    [Token(Token = "0x20034B4")]
    private enum EKey
    {
      [Token(Token = "0x400FA32")] None,
      [Token(Token = "0x400FA33")] Visible,
      [Token(Token = "0x400FA34")] Text,
      [Token(Token = "0x400FA35")] RuneIconEvo,
      [Token(Token = "0x400FA36")] ChangeEnhanceLevelDisplay,
    }
  }
}
