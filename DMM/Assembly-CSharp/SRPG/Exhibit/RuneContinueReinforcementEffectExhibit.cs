// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneContinueReinforcementEffectExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034B1")]
  public class RuneContinueReinforcementEffectExhibit : 
    BaseExhibit,
    IRenderModel<RuneContinueReinforcementEffectModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA2B")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneContinueReinforcementEffectExhibit.EKey), typeof (RuneContinueReinforcementEffectExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9FF")]
    [Address(RVA = "0xAEF900", Offset = "0xAEE700", VA = "0x10AEF900", Slot = "8")]
    public void Render(RuneContinueReinforcementEffectModel model)
    {
    }

    [Token(Token = "0x600EA00")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneContinueReinforcementEffectExhibit()
    {
    }

    [Token(Token = "0x20034B2")]
    private enum EKey
    {
      [Token(Token = "0x400FA2D")] None,
      [Token(Token = "0x400FA2E")] Button,
      [Token(Token = "0x400FA2F")] BulkEnhanceButton,
    }
  }
}
