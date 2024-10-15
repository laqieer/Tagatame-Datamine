// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_AdjustCameraPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011EE")]
  [EventActionInfo("カメラ/調整", "指定したアクターが画面内に収まるようにカメラ位置を調整します。", 5592405, 4473992)]
  public class EventAction_AdjustCameraPosition : EventAction
  {
    [Token(Token = "0x400413B")]
    [FieldOffset(Offset = "0x18")]
    public CameraInterpSpeed InterpSpeed;
    [Token(Token = "0x400413C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string[] ActorIDs;

    [Token(Token = "0x6004C3D")]
    [Address(RVA = "0x1215890", Offset = "0x1214690", VA = "0x11215890", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C3E")]
    [Address(RVA = "0x1215C10", Offset = "0x1214A10", VA = "0x11215C10", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C3F")]
    [Address(RVA = "0x1215C50", Offset = "0x1214A50", VA = "0x11215C50")]
    public EventAction_AdjustCameraPosition()
    {
    }
  }
}
