// Decompiled with JetBrains decompiler
// Type: SRPG.GvGMap
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
  [Token(Token = "0x20025F4")]
  [AddComponentMenu("UI/GvG/GvGMap")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class GvGMap : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B066")]
    public const int PIN_INPUT_REFRESH = 1;
    [Token(Token = "0x400B067")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<GameObject> mMapNodes;
    [Token(Token = "0x400B068")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GvGNode mMapIconTemplate;
    [Token(Token = "0x400B069")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_ScrollRect mScrollRect;
    [Token(Token = "0x400B06A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform mBgRect;
    [Token(Token = "0x400B06B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private AnimationCurve mScrollCurve;
    [Token(Token = "0x400B06C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float mScrollTime;
    [Token(Token = "0x400B06D")]
    [FieldOffset(Offset = "0x0")]
    private static GvGMap mInstance;

    [Token(Token = "0x170017D3")]
    public static GvGMap Instance
    {
      [Token(Token = "0x600A900"), Address(RVA = "0x6BE5B0", Offset = "0x6BD3B0", VA = "0x106BE5B0")] get
      {
        return (GvGMap) null;
      }
    }

    [Token(Token = "0x600A901")]
    [Address(RVA = "0x6BDBD0", Offset = "0x6BC9D0", VA = "0x106BDBD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A902")]
    [Address(RVA = "0x6BE350", Offset = "0x6BD150", VA = "0x106BE350")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A903")]
    [Address(RVA = "0x6BDDC0", Offset = "0x6BCBC0", VA = "0x106BDDC0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A904")]
    [Address(RVA = "0x6BE390", Offset = "0x6BD190", VA = "0x106BE390")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A905")]
    [Address(RVA = "0x6BDBB0", Offset = "0x6BC9B0", VA = "0x106BDBB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A906")]
    [Address(RVA = "0x6BDC20", Offset = "0x6BCA20", VA = "0x106BDC20")]
    public void ForcusMyPort()
    {
    }

    [Token(Token = "0x600A907")]
    [Address(RVA = "0x6BE0E0", Offset = "0x6BCEE0", VA = "0x106BE0E0")]
    public void NodeAutoForcus(int nodeID)
    {
    }

    [Token(Token = "0x600A908")]
    [Address(RVA = "0x6BE4F0", Offset = "0x6BD2F0", VA = "0x106BE4F0")]
    private IEnumerator ScrollTo(
      Transform target_transform,
      SRPG_ScrollRect scroll_rect,
      AnimationCurve curve,
      float scroll_time)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A909")]
    [Address(RVA = "0x6BE590", Offset = "0x6BD390", VA = "0x106BE590")]
    public GvGMap()
    {
    }
  }
}
