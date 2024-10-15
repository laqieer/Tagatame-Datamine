// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PartyToggleExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200342D")]
  public class PartyToggleExhibit : BaseExhibit, IRenderModel<PartyToggleModel>, IRenderModel
  {
    [Token(Token = "0x400F785")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PartyToggleExhibit.EKey), typeof (PartyToggleExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E91F")]
    [Address(RVA = "0xAE5310", Offset = "0xAE4110", VA = "0x10AE5310", Slot = "8")]
    public void Render(PartyToggleModel model)
    {
    }

    [Token(Token = "0x600E920")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PartyToggleExhibit()
    {
    }

    [Token(Token = "0x200342E")]
    private enum EKey
    {
      [Token(Token = "0x400F787")] None,
      [Token(Token = "0x400F788")] Visible,
      [Token(Token = "0x400F789")] Badge,
      [Token(Token = "0x400F78A")] BadgeVisible,
      [Token(Token = "0x400F78B")] Toggle,
      [Token(Token = "0x400F78C")] ToggleIntractable,
    }
  }
}
