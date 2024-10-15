// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGalleryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031D7")]
  public class ReqGalleryItem : WebAPI
  {
    [Token(Token = "0x600DE70")]
    [Address(RVA = "0xA97780", Offset = "0xA96580", VA = "0x10A97780")]
    public ReqGalleryItem(List<ItemParam> items, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DE71")]
    [Address(RVA = "0xA97970", Offset = "0xA96770", VA = "0x10A97970")]
    public ReqGalleryItem(List<ConceptCardParam> cards, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DE72")]
    [Address(RVA = "0xA97B60", Offset = "0xA96960", VA = "0x10A97B60")]
    public ReqGalleryItem(List<ArtifactParam> artifacts, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DE73")]
    [Address(RVA = "0xA97590", Offset = "0xA96390", VA = "0x10A97590")]
    public ReqGalleryItem(List<CrystalParam> crystals, Network.ResponseCallback response)
    {
    }
  }
}
