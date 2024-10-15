// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.WorldRaidBpHealItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200350F")]
  public class WorldRaidBpHealItemExhibit : 
    BaseExhibit,
    IRenderModel<WorldRaidBpHealItemModel>,
    IRenderModel
  {
    [Token(Token = "0x400FBE8")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (WorldRaidBpHealItemExhibit.EKey), typeof (WorldRaidBpHealItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA8A")]
    [Address(RVA = "0xAFE5D0", Offset = "0xAFD3D0", VA = "0x10AFE5D0", Slot = "8")]
    public void Render(WorldRaidBpHealItemModel _model)
    {
    }

    [Token(Token = "0x600EA8B")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public WorldRaidBpHealItemExhibit()
    {
    }

    [Token(Token = "0x2003510")]
    private enum EKey
    {
      [Token(Token = "0x400FBEA")] None,
      [Token(Token = "0x400FBEB")] MinCount,
      [Token(Token = "0x400FBEC")] MaxCount,
      [Token(Token = "0x400FBED")] DispMaxCount,
      [Token(Token = "0x400FBEE")] NeedCoin,
    }
  }
}
