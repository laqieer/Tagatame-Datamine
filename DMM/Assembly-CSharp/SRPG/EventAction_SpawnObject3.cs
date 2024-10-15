// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnObject3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200124E")]
  [EventActionInfo("New/オブジェクト/配置2", "シーンにオブジェクトを配置します。", 4478293, 4491400)]
  public class EventAction_SpawnObject3 : EventAction
  {
    [Token(Token = "0x4004371")]
    public const string ResourceDir = "EventAssets/";
    [Token(Token = "0x4004372")]
    [FieldOffset(Offset = "0x18")]
    [StringIsDemoResourcePath(typeof (GameObject), "EventAssets/")]
    public string ResourceID;
    [Token(Token = "0x4004373")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsObjectList]
    public string ObjectID;
    [Token(Token = "0x4004374")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mResourceLoadRequest;
    [Token(Token = "0x4004375")]
    [FieldOffset(Offset = "0x24")]
    public bool Persistent;
    [Token(Token = "0x4004376")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 Position;
    [Token(Token = "0x4004377")]
    [FieldOffset(Offset = "0x34")]
    [Range(0.0f, 360f)]
    private float Angle;
    [Token(Token = "0x4004378")]
    [FieldOffset(Offset = "0x38")]
    [Range(0.0f, 359f)]
    public float Rotate_x;
    [Token(Token = "0x4004379")]
    [FieldOffset(Offset = "0x3C")]
    [Range(0.0f, 359f)]
    public float Rotate_y;
    [Token(Token = "0x400437A")]
    [FieldOffset(Offset = "0x40")]
    [Range(0.0f, 359f)]
    public float Rotate_z;
    [Token(Token = "0x400437B")]
    [FieldOffset(Offset = "0x44")]
    public Vector3 Scale;
    [Token(Token = "0x400437C")]
    [FieldOffset(Offset = "0x50")]
    public Vector3 mousepos;
    [Token(Token = "0x400437D")]
    [FieldOffset(Offset = "0x5C")]
    private GameObject mGO;

    [Token(Token = "0x6004D8D")]
    [Address(RVA = "0x12311D0", Offset = "0x122FFD0", VA = "0x112311D0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D8E")]
    [Address(RVA = "0x12316E0", Offset = "0x12304E0", VA = "0x112316E0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x170008AF")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D8F"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D90")]
    [Address(RVA = "0x12317C0", Offset = "0x12305C0", VA = "0x112317C0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D91")]
    [Address(RVA = "0x1231180", Offset = "0x122FF80", VA = "0x11231180")]
    public EventAction_SpawnObject3()
    {
    }
  }
}
