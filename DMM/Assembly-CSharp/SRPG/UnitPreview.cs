// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPreview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200117F")]
  [AddComponentMenu("Common/UnitPreview")]
  public class UnitPreview : UnitController
  {
    [Token(Token = "0x4003F6C")]
    private const string ID_IDLE = "idle";
    [Token(Token = "0x4003F6D")]
    private const string ID_ACTION = "action";
    [Token(Token = "0x4003F6E")]
    [FieldOffset(Offset = "0x128")]
    public bool PlayAction;
    [Token(Token = "0x4003F6F")]
    [FieldOffset(Offset = "0x129")]
    private bool mPlayingAction;
    [Token(Token = "0x4003F70")]
    [FieldOffset(Offset = "0x12C")]
    public int DefaultLayer;
    [Token(Token = "0x4003F71")]
    [FieldOffset(Offset = "0x130")]
    private bool mLoadThreadFlag;

    [Token(Token = "0x17000836")]
    public bool LoadThreadFlag
    {
      [Token(Token = "0x6004ABA"), Address(RVA = "0x1214B70", Offset = "0x1213970", VA = "0x11214B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004ABB")]
    [Address(RVA = "0x12149F0", Offset = "0x12137F0", VA = "0x112149F0", Slot = "4")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6004ABC")]
    [Address(RVA = "0x12148F0", Offset = "0x12136F0", VA = "0x112148F0", Slot = "21")]
    protected override void PostSetup()
    {
    }

    [Token(Token = "0x6004ABD")]
    [Address(RVA = "0x1214A20", Offset = "0x1213820", VA = "0x11214A20", Slot = "15")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6004ABE")]
    [Address(RVA = "0x1214850", Offset = "0x1213650", VA = "0x11214850", Slot = "5")]
    protected override void OnEnable()
    {
    }

    [Token(Token = "0x6004ABF")]
    [Address(RVA = "0x12148D0", Offset = "0x12136D0", VA = "0x112148D0", Slot = "12")]
    public override void OnGenerateParticle(GameObject go)
    {
    }

    [Token(Token = "0x6004AC0")]
    [Address(RVA = "0x12147E0", Offset = "0x12135E0", VA = "0x112147E0")]
    private IEnumerator LoadThread() => (IEnumerator) null;

    [Token(Token = "0x6004AC1")]
    [Address(RVA = "0x1214730", Offset = "0x1213530", VA = "0x11214730")]
    public Transform GetHeadPosition() => (Transform) null;

    [Token(Token = "0x6004AC2")]
    [Address(RVA = "0x1214B10", Offset = "0x1213910", VA = "0x11214B10")]
    public UnitPreview()
    {
    }
  }
}
