// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftReady
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002738")]
  [FlowNode.Pin(4, "Finish SYNC", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(3, "Finish Scene", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "Finish Place", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Finish Place", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftReady")]
  public class VersusDraftReady : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B91B")]
    private const int INPUT_PIN_FINISH_PLACE = 1;
    [Token(Token = "0x400B91C")]
    private const int OUTPUT_PIN_FINISH_PLACE = 2;
    [Token(Token = "0x400B91D")]
    private const int OUTPUT_PIN_FINISH_SCENE = 3;
    [Token(Token = "0x400B91E")]
    private const int OUTPUT_PIN_FINISH_SYNC = 4;
    [Token(Token = "0x400B91F")]
    private const int COMPLETE_MESS_OFFSET = 100;
    [Token(Token = "0x400B920")]
    private const int PLAYER_MAX = 2;
    [Token(Token = "0x400B921")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTimerText;
    [Token(Token = "0x400B922")]
    [FieldOffset(Offset = "0x10")]
    private StateMachine<VersusDraftReady> mStateMachine;
    [Token(Token = "0x400B923")]
    [FieldOffset(Offset = "0x14")]
    private float mPlaceSec;
    [Token(Token = "0x400B924")]
    [FieldOffset(Offset = "0x18")]
    private List<VersusDraftList.VersusDraftMessageData> mMessageDataList;

    [Token(Token = "0x1700184D")]
    private Text TimerText
    {
      [Token(Token = "0x600AFEB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x600AFEC")]
    [Address(RVA = "0x742C70", Offset = "0x741A70", VA = "0x10742C70")]
    private void Start()
    {
    }

    [Token(Token = "0x600AFED")]
    [Address(RVA = "0x742C30", Offset = "0x741A30", VA = "0x10742C30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AFEE")]
    [Address(RVA = "0x742E80", Offset = "0x741C80", VA = "0x10742E80")]
    private void Update()
    {
    }

    [Token(Token = "0x600AFEF")]
    [Address(RVA = "0x742D50", Offset = "0x741B50", VA = "0x10742D50")]
    private void UpdatePhotonMessage()
    {
    }

    [Token(Token = "0x600AFF0")]
    public void GotoState<StateType>() where StateType : State<VersusDraftReady>, new()
    {
    }

    [Token(Token = "0x600AFF1")]
    [Address(RVA = "0x743020", Offset = "0x741E20", VA = "0x10743020")]
    public VersusDraftReady()
    {
    }

    [Token(Token = "0x2002739")]
    private class State_UnitPlacing : State<VersusDraftReady>
    {
      [Token(Token = "0x400B925")]
      [FieldOffset(Offset = "0xC")]
      private bool mEnable;
      [Token(Token = "0x400B926")]
      [FieldOffset(Offset = "0x10")]
      private float mTimer;
      [Token(Token = "0x400B927")]
      [FieldOffset(Offset = "0x14")]
      private MultiPlayVersusReady mMPVR;

      [Token(Token = "0x600AFF2")]
      [Address(RVA = "0x73A1D0", Offset = "0x738FD0", VA = "0x1073A1D0", Slot = "4")]
      public override void Begin(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFF3")]
      [Address(RVA = "0x73A230", Offset = "0x739030", VA = "0x1073A230", Slot = "5")]
      public override void Update(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFF4")]
      [Address(RVA = "0x73A3A0", Offset = "0x7391A0", VA = "0x1073A3A0")]
      public State_UnitPlacing()
      {
      }
    }

    [Token(Token = "0x200273A")]
    private class State_UpdatePlayer : State<VersusDraftReady>
    {
      [Token(Token = "0x600AFF5")]
      [Address(RVA = "0x73A5F0", Offset = "0x7393F0", VA = "0x1073A5F0", Slot = "4")]
      public override void Begin(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFF6")]
      [Address(RVA = "0x73ACC0", Offset = "0x739AC0", VA = "0x1073ACC0", Slot = "5")]
      public override void Update(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFF7")]
      [Address(RVA = "0x73AD90", Offset = "0x739B90", VA = "0x1073AD90")]
      public State_UpdatePlayer()
      {
      }
    }

    [Token(Token = "0x200273C")]
    private class State_UpdatePlayerSync : State<VersusDraftReady>
    {
      [Token(Token = "0x600AFFB")]
      [Address(RVA = "0x73A3E0", Offset = "0x7391E0", VA = "0x1073A3E0", Slot = "4")]
      public override void Begin(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFFC")]
      [Address(RVA = "0x73A4E0", Offset = "0x7392E0", VA = "0x1073A4E0", Slot = "5")]
      public override void Update(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFFD")]
      [Address(RVA = "0x73A5B0", Offset = "0x7393B0", VA = "0x1073A5B0")]
      public State_UpdatePlayerSync()
      {
      }
    }

    [Token(Token = "0x200273D")]
    private class State_RoomUpdate : State<VersusDraftReady>
    {
      [Token(Token = "0x400B92A")]
      private const int PARTY_SLOT_COUNT = 3;

      [Token(Token = "0x600AFFE")]
      [Address(RVA = "0x739C70", Offset = "0x738A70", VA = "0x10739C70", Slot = "4")]
      public override void Begin(VersusDraftReady self)
      {
      }

      [Token(Token = "0x600AFFF")]
      [Address(RVA = "0x73A190", Offset = "0x738F90", VA = "0x1073A190")]
      public State_RoomUpdate()
      {
      }
    }
  }
}
