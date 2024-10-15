// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PlayerInfoExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003483")]
  public class PlayerInfoExhibit : BaseExhibit, IRenderModel<PlayerInfoModel>, IRenderModel
  {
    [Token(Token = "0x400F933")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PlayerInfoExhibit.EKey), typeof (PlayerInfoExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9AC")]
    [Address(RVA = "0xAE5850", Offset = "0xAE4650", VA = "0x10AE5850", Slot = "8")]
    public void Render(PlayerInfoModel model)
    {
    }

    [Token(Token = "0x600E9AD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PlayerInfoExhibit()
    {
    }

    [Token(Token = "0x2003484")]
    private enum EKey
    {
      [Token(Token = "0x400F935")] None,
      [Token(Token = "0x400F936")] Name,
      [Token(Token = "0x400F937")] CustomId,
    }
  }
}
