// Decompiled with JetBrains decompiler
// Type: SRPG.PetController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE9")]
  [AddComponentMenu("Common/PetController")]
  public class PetController : AnimationPlayer
  {
    [Token(Token = "0x4003845")]
    public const string PetPath = "Pets/";
    [Token(Token = "0x4003846")]
    public const string PetAnimationPath = "CHM/";
    [Token(Token = "0x4003847")]
    private const string ID_IDLE = "IDLE";
    [Token(Token = "0x4003848")]
    private const string ID_RUN = "RUN";
    [Token(Token = "0x4003849")]
    [FieldOffset(Offset = "0x68")]
    public string PetID;
    [Token(Token = "0x400384A")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject Owner;
    [Token(Token = "0x400384B")]
    [FieldOffset(Offset = "0x70")]
    private GameObject mTarget;
    [Token(Token = "0x400384C")]
    [FieldOffset(Offset = "0x74")]
    private bool mLoading;
    [Token(Token = "0x400384D")]
    [FieldOffset(Offset = "0x78")]
    private StateMachine<PetController> mStateMachine;
    [Token(Token = "0x400384E")]
    [FieldOffset(Offset = "0x7C")]
    private Vector3 mVelocity;
    [Token(Token = "0x400384F")]
    [FieldOffset(Offset = "0x88")]
    private Vector3 mAcceleration;

    [Token(Token = "0x6004242")]
    [Address(RVA = "0x119BEE0", Offset = "0x119ACE0", VA = "0x1119BEE0", Slot = "4")]
    protected override void Start()
    {
    }

    [Token(Token = "0x1700060D")]
    public override bool IsLoading
    {
      [Token(Token = "0x6004243"), Address(RVA = "0x119C060", Offset = "0x119AE60", VA = "0x1119C060", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004244")]
    [Address(RVA = "0x119BE70", Offset = "0x119AC70", VA = "0x1119BE70")]
    private IEnumerator AsyncSetup() => (IEnumerator) null;

    [Token(Token = "0x6004245")]
    [Address(RVA = "0x119BFC0", Offset = "0x119ADC0", VA = "0x1119BFC0", Slot = "15")]
    protected override void Update()
    {
    }

    [Token(Token = "0x6004246")]
    [Address(RVA = "0x119C010", Offset = "0x119AE10", VA = "0x1119C010")]
    public PetController()
    {
    }

    [Token(Token = "0x2000FEA")]
    private class State : SRPG.State<PetController>
    {
      [Token(Token = "0x6004248")]
      [Address(RVA = "0x119C1F0", Offset = "0x119AFF0", VA = "0x1119C1F0")]
      public State()
      {
      }
    }

    [Token(Token = "0x2000FEB")]
    private class State_Idle : PetController.State
    {
      [Token(Token = "0x6004249")]
      [Address(RVA = "0x119C1A0", Offset = "0x119AFA0", VA = "0x1119C1A0", Slot = "4")]
      public override void Begin(PetController self)
      {
      }

      [Token(Token = "0x600424A")]
      [Address(RVA = "0x119C1F0", Offset = "0x119AFF0", VA = "0x1119C1F0")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x2000FEC")]
    private class State_Move : PetController.State
    {
      [Token(Token = "0x600424B")]
      [Address(RVA = "0x119C1F0", Offset = "0x119AFF0", VA = "0x1119C1F0")]
      public State_Move()
      {
      }
    }
  }
}
