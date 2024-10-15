// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200148A")]
  [FlowNode.NodeType("System/ReqArtifact/ReqArtifactFavorite", 32741)]
  [FlowNode.Pin(0, "お気に入り 追加", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "お気に入り 削除", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Add Success", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "Remove Success", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  public class FlowNode_ReqArtifactFavorite : FlowNode_Network
  {
    [Token(Token = "0x4004BC9")]
    private const int PIN_ID_FAVORITE_ADD = 0;
    [Token(Token = "0x4004BCA")]
    private const int PIN_ID_FAVORITE_REMOVE = 1;
    [Token(Token = "0x4004BCB")]
    private const int PIN_ID_FAVORITE_ADD_SUCCESS = 2;
    [Token(Token = "0x4004BCC")]
    private const int PIN_ID_FAVORITE_REMOVE_SUCCESS = 3;
    [Token(Token = "0x4004BCD")]
    [FieldOffset(Offset = "0x20")]
    private bool success;

    [Token(Token = "0x60055CC")]
    [Address(RVA = "0x12B72F0", Offset = "0x12B60F0", VA = "0x112B72F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055CD")]
    [Address(RVA = "0x12B77D0", Offset = "0x12B65D0", VA = "0x112B77D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055CE")]
    [Address(RVA = "0x12B7540", Offset = "0x12B6340", VA = "0x112B7540")]
    public void OnFavoriteRemove(WWWResult www)
    {
    }

    [Token(Token = "0x60055CF")]
    [Address(RVA = "0x12B74D0", Offset = "0x12B62D0", VA = "0x112B74D0")]
    public void OnFavoriteAdd(WWWResult www)
    {
    }

    [Token(Token = "0x60055D0")]
    [Address(RVA = "0x12B75B0", Offset = "0x12B63B0", VA = "0x112B75B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055D1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactFavorite()
    {
    }
  }
}
