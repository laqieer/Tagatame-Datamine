// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultArtifactDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200243E")]
  [AddComponentMenu("UI/GachaResultArtifactDetail")]
  [FlowNode.Pin(2, "Refreshed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Close", FlowNode.PinTypes.Output, 100)]
  public class GachaResultArtifactDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A43C")]
    [FieldOffset(Offset = "0xC")]
    private readonly int OUT_CLOSE_DETAIL;
    [Token(Token = "0x400A43D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ArtifactInfo;
    [Token(Token = "0x400A43E")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Bg;
    [Token(Token = "0x400A43F")]
    [FieldOffset(Offset = "0x18")]
    private ArtifactData mCurrentArtifact;
    [Token(Token = "0x400A440")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button BackBtn;

    [Token(Token = "0x6009E0E")]
    [Address(RVA = "0x60A770", Offset = "0x609570", VA = "0x1060A770", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009E0F")]
    [Address(RVA = "0x60AC70", Offset = "0x609A70", VA = "0x1060AC70")]
    private void Start()
    {
    }

    [Token(Token = "0x6009E10")]
    [Address(RVA = "0x60A8B0", Offset = "0x6096B0", VA = "0x1060A8B0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009E11")]
    [Address(RVA = "0x60A890", Offset = "0x609690", VA = "0x1060A890")]
    private void OnCloseDetail()
    {
    }

    [Token(Token = "0x6009E12")]
    [Address(RVA = "0x60ABC0", Offset = "0x6099C0", VA = "0x1060ABC0")]
    public void Setup(int _index)
    {
    }

    [Token(Token = "0x6009E13")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void Setup(ArtifactData _artifact)
    {
    }

    [Token(Token = "0x6009E14")]
    [Address(RVA = "0x60A9D0", Offset = "0x6097D0", VA = "0x1060A9D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009E15")]
    [Address(RVA = "0x60A790", Offset = "0x609590", VA = "0x1060A790")]
    private ArtifactData CreateArtifactData(ArtifactParam param, int rarity) => (ArtifactData) null;

    [Token(Token = "0x6009E16")]
    [Address(RVA = "0x60AD20", Offset = "0x609B20", VA = "0x1060AD20")]
    public GachaResultArtifactDetail()
    {
    }
  }
}
