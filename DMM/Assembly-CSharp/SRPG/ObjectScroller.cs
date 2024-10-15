// Decompiled with JetBrains decompiler
// Type: SRPG.ObjectScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029FA")]
  public class ObjectScroller : MonoBehaviour
  {
    [Token(Token = "0x400CBF2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_ScrollRect scrollRect;
    [Token(Token = "0x400CBF3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private AnimationCurve scrollCurve;
    [Token(Token = "0x400CBF4")]
    [FieldOffset(Offset = "0x14")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float scrollTime;
    [Token(Token = "0x400CBF5")]
    [FieldOffset(Offset = "0x18")]
    private ObjectScroller.ScrollType scrollType;

    [Token(Token = "0x600BF53")]
    [Address(RVA = "0x856130", Offset = "0x854F30", VA = "0x10856130")]
    private void Start()
    {
    }

    [Token(Token = "0x600BF54")]
    [Address(RVA = "0x856030", Offset = "0x854E30", VA = "0x10856030")]
    public void Scroll(Transform target)
    {
    }

    [Token(Token = "0x600BF55")]
    [Address(RVA = "0x8560B0", Offset = "0x854EB0", VA = "0x108560B0")]
    public void Scroll(Transform target, ObjectScroller.ScrollType scrollType)
    {
    }

    [Token(Token = "0x600BF56")]
    [Address(RVA = "0x855FC0", Offset = "0x854DC0", VA = "0x10855FC0")]
    private IEnumerator ScrollTo(Transform target) => (IEnumerator) null;

    [Token(Token = "0x600BF57")]
    [Address(RVA = "0x8561B0", Offset = "0x854FB0", VA = "0x108561B0")]
    public ObjectScroller()
    {
    }

    [Token(Token = "0x20029FB")]
    public enum ScrollType
    {
      [Token(Token = "0x400CBF7")] All,
      [Token(Token = "0x400CBF8")] Horizontal,
      [Token(Token = "0x400CBF9")] Vertical,
    }
  }
}
