// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitJobListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034FD")]
  public class UnitJobListExhibit : BaseExhibit, IRenderModel<UnitJobListModel>, IRenderModel
  {
    [Token(Token = "0x400FB89")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitJobListExhibit.EKey), typeof (UnitJobListExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA74")]
    [Address(RVA = "0xAFA8A0", Offset = "0xAF96A0", VA = "0x10AFA8A0", Slot = "8")]
    public void Render(UnitJobListModel model)
    {
    }

    [Token(Token = "0x600EA75")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitJobListExhibit()
    {
    }

    [Token(Token = "0x20034FE")]
    private enum EKey
    {
      [Token(Token = "0x400FB8B")] None,
      [Token(Token = "0x400FB8C")] JobIcon,
      [Token(Token = "0x400FB8D")] JobName,
      [Token(Token = "0x400FB8E")] Hide,
      [Token(Token = "0x400FB8F")] Key,
      [Token(Token = "0x400FB90")] HideJobName,
    }
  }
}
