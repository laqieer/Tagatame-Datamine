// Decompiled with JetBrains decompiler
// Type: SRPG.Models.GachaTicketListItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003349")]
  public class GachaTicketListItemModel : BaseItemModel
  {
    [Token(Token = "0x400F204")]
    [FieldOffset(Offset = "0x20")]
    private GachaTopParamNew mParam;

    [Token(Token = "0x17001E5B")]
    public GachaTopParamNew Param
    {
      [Token(Token = "0x600E2DD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (GachaTopParamNew) null;
      }
    }

    [Token(Token = "0x600E2DE")]
    [Address(RVA = "0xAB1740", Offset = "0xAB0540", VA = "0x10AB1740")]
    public void Initialize(ItemData itemData, GachaTopParamNew param)
    {
    }

    [Token(Token = "0x600E2DF")]
    [Address(RVA = "0xAB1770", Offset = "0xAB0570", VA = "0x10AB1770")]
    public GachaTicketListItemModel()
    {
    }
  }
}
