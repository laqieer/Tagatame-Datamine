// Decompiled with JetBrains decompiler
// Type: SRPG.VersusCpuInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002749")]
  [FlowNode.Pin(200, "Selected", FlowNode.PinTypes.Output, 200)]
  [AddComponentMenu("UI/Multi/Versus/VersusCpuInfo")]
  [FlowNode.Pin(100, "Refresh", FlowNode.PinTypes.Input, 100)]
  public class VersusCpuInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B980")]
    [FieldOffset(Offset = "0xC")]
    public ListItemEvents CpuPlayerTemplate;
    [Token(Token = "0x400B981")]
    [FieldOffset(Offset = "0x10")]
    public GameObject CpuList;
    [Token(Token = "0x400B982")]
    [FieldOffset(Offset = "0x14")]
    public GameObject MapInfo;
    [Token(Token = "0x400B983")]
    [FieldOffset(Offset = "0x18")]
    public GameObject PartyInfo;
    [Token(Token = "0x400B984")]
    [FieldOffset(Offset = "0x1C")]
    public Color[] RankColor;
    [Token(Token = "0x400B985")]
    [FieldOffset(Offset = "0x20")]
    private List<ListItemEvents> mVersusMember;

    [Token(Token = "0x600B040")]
    [Address(RVA = "0x74DD30", Offset = "0x74CB30", VA = "0x1074DD30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B041")]
    [Address(RVA = "0x74DDA0", Offset = "0x74CBA0", VA = "0x1074DDA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B042")]
    [Address(RVA = "0x74E220", Offset = "0x74D020", VA = "0x1074E220")]
    private void Start()
    {
    }

    [Token(Token = "0x600B043")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B044")]
    [Address(RVA = "0x74DFB0", Offset = "0x74CDB0", VA = "0x1074DFB0")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B045")]
    [Address(RVA = "0x74E1B0", Offset = "0x74CFB0", VA = "0x1074E1B0")]
    private IEnumerator RefreshEnemy() => (IEnumerator) null;

    [Token(Token = "0x600B046")]
    [Address(RVA = "0x74DE10", Offset = "0x74CC10", VA = "0x1074DE10")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600B047")]
    [Address(RVA = "0x74DED0", Offset = "0x74CCD0", VA = "0x1074DED0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B048")]
    [Address(RVA = "0x74DE60", Offset = "0x74CC60", VA = "0x1074DE60")]
    private void OnOpenDetail(GameObject _go)
    {
    }

    [Token(Token = "0x600B049")]
    [Address(RVA = "0x74E2B0", Offset = "0x74D0B0", VA = "0x1074E2B0")]
    public VersusCpuInfo()
    {
    }
  }
}
