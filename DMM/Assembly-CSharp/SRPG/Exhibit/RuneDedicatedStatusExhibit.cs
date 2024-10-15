// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDedicatedStatusExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034A8")]
  public class RuneDedicatedStatusExhibit : 
    BaseExhibit,
    IRenderModel<RuneDedicatedModel>,
    IRenderModel
  {
    [Token(Token = "0x400F9FB")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDedicatedStatusExhibit.EKey), typeof (RuneDedicatedStatusExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E9ED")]
    [Address(RVA = "0xAF08B0", Offset = "0xAEF6B0", VA = "0x10AF08B0", Slot = "8")]
    public void Render(RuneDedicatedModel model)
    {
    }

    [Token(Token = "0x600E9EE")]
    [Address(RVA = "0xAF0BA0", Offset = "0xAEF9A0", VA = "0x10AF0BA0")]
    private void SetStatusList(BaseStatus add_status, BaseStatus scale_status)
    {
    }

    [Token(Token = "0x600E9EF")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDedicatedStatusExhibit()
    {
    }

    [Token(Token = "0x20034A9")]
    private enum EKey
    {
      [Token(Token = "0x400F9FD")] None,
      [Token(Token = "0x400F9FE")] BEFORE_RUNE_NAME,
      [Token(Token = "0x400F9FF")] BEFORE_RUNE_TYPE,
      [Token(Token = "0x400FA00")] BEFORE_RUNE_STATUS_VALUE,
      [Token(Token = "0x400FA01")] BEFORE_RUNE_CONDITIONS,
      [Token(Token = "0x400FA02")] AFTER_RUNE_NAME,
      [Token(Token = "0x400FA03")] AFTER_RUNE_TYPE,
      [Token(Token = "0x400FA04")] AFTER_RUNE_STATUS_VALUE,
      [Token(Token = "0x400FA05")] AFTER_RUNE_CONDITIONS,
      [Token(Token = "0x400FA06")] BEFORE_RUNE_DEDICATED_STATE,
      [Token(Token = "0x400FA07")] AFTER_RUNE_DEDICATED_STATE,
    }
  }
}
