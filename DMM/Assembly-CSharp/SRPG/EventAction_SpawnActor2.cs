// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnActor2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001241")]
  [EventActionInfo("New/アクター/配置", "キャラクターを配置します", 6702148, 11158596)]
  public class EventAction_SpawnActor2 : EventAction
  {
    [Token(Token = "0x4004327")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorID]
    public string ActorID;
    [Token(Token = "0x4004328")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsLocalUnitIDPopup]
    public string UnitID;
    [Token(Token = "0x4004329")]
    [FieldOffset(Offset = "0x20")]
    [StringIsJobIDPopup]
    public string JobID;
    [Token(Token = "0x400432A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public Vector3 Position;
    [Token(Token = "0x400432B")]
    [FieldOffset(Offset = "0x30")]
    protected TacticsUnitController mController;
    [Token(Token = "0x400432C")]
    [FieldOffset(Offset = "0x34")]
    public bool Persistent;
    [Token(Token = "0x400432D")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public int Angle;
    [Token(Token = "0x400432E")]
    [FieldOffset(Offset = "0x3C")]
    [Range(0.0f, 359f)]
    public float RotationX;
    [Token(Token = "0x400432F")]
    [FieldOffset(Offset = "0x40")]
    [Range(0.0f, 359f)]
    public float RotationY;
    [Token(Token = "0x4004330")]
    [FieldOffset(Offset = "0x44")]
    [Range(0.0f, 359f)]
    public float RotationZ;
    [Token(Token = "0x4004331")]
    [FieldOffset(Offset = "0x48")]
    public bool ShowEquipments;
    [Token(Token = "0x4004332")]
    [FieldOffset(Offset = "0x49")]
    [Tooltip("マス目にスナップさせるか？")]
    public bool MoveSnap;
    [Token(Token = "0x4004333")]
    [FieldOffset(Offset = "0x4A")]
    [Tooltip("地面にスナップさせるか？")]
    public bool GroundSnap;
    [Token(Token = "0x4004334")]
    [FieldOffset(Offset = "0x4B")]
    [Tooltip("表示設定")]
    public bool Display;
    [Token(Token = "0x4004335")]
    [FieldOffset(Offset = "0x4C")]
    [Tooltip("ゆれもの設定")]
    public bool Yuremono;
    [Token(Token = "0x4004336")]
    [FieldOffset(Offset = "0x50")]
    public TacticsUnitController.PostureTypes Posture;

    [Token(Token = "0x6004D55")]
    [Address(RVA = "0x122FCE0", Offset = "0x122EAE0", VA = "0x1122FCE0")]
    private GameObject GetPersistentScene() => (GameObject) null;

    [Token(Token = "0x170008A0")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D56"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D57")]
    [Address(RVA = "0x1230000", Offset = "0x122EE00", VA = "0x11230000", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D58")]
    [Address(RVA = "0x122FD90", Offset = "0x122EB90", VA = "0x1122FD90", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D59")]
    [Address(RVA = "0x122FF60", Offset = "0x122ED60", VA = "0x1122FF60", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004D5A")]
    [Address(RVA = "0x1230070", Offset = "0x122EE70", VA = "0x11230070")]
    public EventAction_SpawnActor2()
    {
    }
  }
}
