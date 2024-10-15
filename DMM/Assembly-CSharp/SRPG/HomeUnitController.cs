// Decompiled with JetBrains decompiler
// Type: SRPG.HomeUnitController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FBF")]
  [AddComponentMenu("Common/HomeUnitController")]
  public class HomeUnitController : UnitController
  {
    [Token(Token = "0x4003792")]
    private const string ID_IDLE = "idle";
    [Token(Token = "0x4003793")]
    private const string ID_ACTION = "action";
    [Token(Token = "0x4003794")]
    [FieldOffset(Offset = "0x128")]
    public Color DirectLitColor;
    [Token(Token = "0x4003795")]
    [FieldOffset(Offset = "0x138")]
    public Color IndirectLitColor;

    [Token(Token = "0x600417A")]
    [Address(RVA = "0x1193640", Offset = "0x1192440", VA = "0x11193640")]
    public static SectionParam GetHomeWorld() => (SectionParam) null;

    [Token(Token = "0x600417B")]
    [Address(RVA = "0x11938D0", Offset = "0x11926D0", VA = "0x111938D0", Slot = "4")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600417C")]
    [Address(RVA = "0x10A3390", Offset = "0x10A2190", VA = "0x110A3390", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600417D")]
    [Address(RVA = "0x11937E0", Offset = "0x11925E0", VA = "0x111937E0", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x600417E")]
    [Address(RVA = "0x11937D0", Offset = "0x11925D0", VA = "0x111937D0", Slot = "6")]
    protected override void OnDisable()
    {
    }

    [Token(Token = "0x600417F")]
    [Address(RVA = "0x11937F0", Offset = "0x11925F0", VA = "0x111937F0", Slot = "21")]
    protected override void PostSetup()
    {
    }

    [Token(Token = "0x6004180")]
    [Address(RVA = "0x1193760", Offset = "0x1192560", VA = "0x11193760")]
    private IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6004181")]
    [Address(RVA = "0x1193930", Offset = "0x1192730", VA = "0x11193930")]
    public HomeUnitController()
    {
    }
  }
}
