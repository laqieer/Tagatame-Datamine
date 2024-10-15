// Decompiled with JetBrains decompiler
// Type: SRPG.GraphicsRaycasterExtend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E32")]
  [AddComponentMenu("Event/Graphic Raycaster Extend")]
  [RequireComponent(typeof (Canvas))]
  public class GraphicsRaycasterExtend : BaseRaycaster
  {
    [Token(Token = "0x4002B28")]
    protected const int kNoEventMaskSet = -1;
    [Token(Token = "0x4002B29")]
    [FieldOffset(Offset = "0x10")]
    [FormerlySerializedAs("ignoreReversedGraphics")]
    [SerializeField]
    private bool m_IgnoreReversedGraphics;
    [Token(Token = "0x4002B2A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [FormerlySerializedAs("blockingObjects")]
    private GraphicsRaycasterExtend.BlockingObjects m_BlockingObjects;
    [Token(Token = "0x4002B2B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected LayerMask m_BlockingMask;
    [Token(Token = "0x4002B2C")]
    [FieldOffset(Offset = "0x1C")]
    private Canvas m_Canvas;
    [Token(Token = "0x4002B2D")]
    [FieldOffset(Offset = "0x20")]
    [NonSerialized]
    private List<Graphic> m_RaycastResults;
    [Token(Token = "0x4002B2E")]
    [FieldOffset(Offset = "0x0")]
    [NonSerialized]
    private static readonly List<Graphic> s_SortedGraphics;

    [Token(Token = "0x1700043A")]
    public override int sortOrderPriority
    {
      [Token(Token = "0x6003A8E"), Address(RVA = "0x10DDF50", Offset = "0x10DCD50", VA = "0x110DDF50", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700043B")]
    public override int renderOrderPriority
    {
      [Token(Token = "0x6003A8F"), Address(RVA = "0x10DDEE0", Offset = "0x10DCCE0", VA = "0x110DDEE0", Slot = "21")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700043C")]
    public bool ignoreReversedGraphics
    {
      [Token(Token = "0x6003A90"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003A91"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
      {
      }
    }

    [Token(Token = "0x1700043D")]
    public GraphicsRaycasterExtend.BlockingObjects blockingObjects
    {
      [Token(Token = "0x6003A92"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new GraphicsRaycasterExtend.BlockingObjects();
      }
      [Token(Token = "0x6003A93"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] set
      {
      }
    }

    [Token(Token = "0x1700043E")]
    public LayerMask blockingMask
    {
      [Token(Token = "0x6003A94"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new LayerMask();
      }
      [Token(Token = "0x6003A95"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] set
      {
      }
    }

    [Token(Token = "0x6003A96")]
    [Address(RVA = "0x10DDD30", Offset = "0x10DCB30", VA = "0x110DDD30")]
    protected GraphicsRaycasterExtend()
    {
    }

    [Token(Token = "0x1700043F")]
    private Canvas canvas
    {
      [Token(Token = "0x6003A97"), Address(RVA = "0x10DDDB0", Offset = "0x10DCBB0", VA = "0x110DDDB0")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x6003A98")]
    [Address(RVA = "0x10DD650", Offset = "0x10DC450", VA = "0x110DD650")]
    public Vector3 RelativeMouseAtScaled(Vector2 position) => new Vector3();

    [Token(Token = "0x6003A99")]
    [Address(RVA = "0x10DC840", Offset = "0x10DB640", VA = "0x110DC840", Slot = "17")]
    public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
    {
    }

    [Token(Token = "0x17000440")]
    public override UnityEngine.Camera eventCamera
    {
      [Token(Token = "0x6003A9A"), Address(RVA = "0x10DDE30", Offset = "0x10DCC30", VA = "0x110DDE30", Slot = "18")] get
      {
        return (UnityEngine.Camera) null;
      }
    }

    [Token(Token = "0x6003A9B")]
    [Address(RVA = "0x10DC3D0", Offset = "0x10DB1D0", VA = "0x110DC3D0")]
    private static void Raycast(
      Canvas canvas,
      UnityEngine.Camera eventCamera,
      Vector2 pointerPosition,
      IList<Graphic> foundGraphics,
      List<Graphic> results)
    {
    }

    [Token(Token = "0x6003A9C")]
    [Address(RVA = "0x10DDCB0", Offset = "0x10DCAB0", VA = "0x110DDCB0")]
    static GraphicsRaycasterExtend()
    {
    }

    [Token(Token = "0x2000E33")]
    public enum BlockingObjects
    {
      [Token(Token = "0x4002B30")] None,
      [Token(Token = "0x4002B31")] TwoD,
      [Token(Token = "0x4002B32")] ThreeD,
      [Token(Token = "0x4002B33")] All,
    }
  }
}
