// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnObject2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200124C")]
  [EventActionInfo("New/オブジェクト/配置", "シーンにオブジェクトを配置します。", 4478293, 4491400)]
  public class EventAction_SpawnObject2 : EventAction
  {
    [Token(Token = "0x4004361")]
    public const string ResourceDir = "EventAssets/";
    [Token(Token = "0x4004362")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePathPopup(typeof (GameObject), "EventAssets/")]
    public string ResourceID;
    [Token(Token = "0x4004363")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsObjectList]
    public string ObjectID;
    [Token(Token = "0x4004364")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mResourceLoadRequest;
    [Token(Token = "0x4004365")]
    [FieldOffset(Offset = "0x24")]
    public bool Persistent;
    [Token(Token = "0x4004366")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 Position;
    [Token(Token = "0x4004367")]
    [FieldOffset(Offset = "0x34")]
    [Range(0.0f, 360f)]
    private float Angle;
    [Token(Token = "0x4004368")]
    [FieldOffset(Offset = "0x38")]
    [Range(0.0f, 359f)]
    public float Rotate_x;
    [Token(Token = "0x4004369")]
    [FieldOffset(Offset = "0x3C")]
    [Range(0.0f, 359f)]
    public float Rotate_y;
    [Token(Token = "0x400436A")]
    [FieldOffset(Offset = "0x40")]
    [Range(0.0f, 359f)]
    public float Rotate_z;
    [Token(Token = "0x400436B")]
    [FieldOffset(Offset = "0x44")]
    public Vector3 Scale;
    [Token(Token = "0x400436C")]
    [FieldOffset(Offset = "0x50")]
    public Vector3 mousepos;
    [Token(Token = "0x400436D")]
    [FieldOffset(Offset = "0x5C")]
    private GameObject mGO;

    [Token(Token = "0x6004D82")]
    [Address(RVA = "0x1230B20", Offset = "0x122F920", VA = "0x11230B20", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D83")]
    [Address(RVA = "0x1231030", Offset = "0x122FE30", VA = "0x11231030", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x170008AC")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D84"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D85")]
    [Address(RVA = "0x1231110", Offset = "0x122FF10", VA = "0x11231110", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D86")]
    [Address(RVA = "0x1231180", Offset = "0x122FF80", VA = "0x11231180")]
    public EventAction_SpawnObject2()
    {
    }
  }
}
