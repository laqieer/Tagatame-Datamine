// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneFilterToggleExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034BB")]
  public class RuneFilterToggleExhibit : 
    BaseExhibit,
    IRenderModel<RuneFilterToggleModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA49")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneFilterToggleExhibit.EKey), typeof (RuneFilterToggleExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA09")]
    [Address(RVA = "0xAF2060", Offset = "0xAF0E60", VA = "0x10AF2060", Slot = "8")]
    public void Render(RuneFilterToggleModel model)
    {
    }

    [Token(Token = "0x600EA0A")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneFilterToggleExhibit()
    {
    }

    [Token(Token = "0x20034BC")]
    private enum EKey
    {
      [Token(Token = "0x400FA4B")] None,
      [Token(Token = "0x400FA4C")] SetEffIcon,
      [Token(Token = "0x400FA4D")] SetEffText,
      [Token(Token = "0x400FA4E")] ActivateSetEffText,
      [Token(Token = "0x400FA4F")] EvoStatusText,
    }
  }
}
