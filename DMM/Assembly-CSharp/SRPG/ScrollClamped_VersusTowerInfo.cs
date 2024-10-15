// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollClamped_VersusTowerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A73")]
  [RequireComponent(typeof (ScrollListController))]
  [AddComponentMenu("UI/ScrollClamped_VersusTowerInfo")]
  public class ScrollClamped_VersusTowerInfo : MonoBehaviour, ScrollListSetUp
  {
    [Token(Token = "0x400CEA2")]
    [FieldOffset(Offset = "0xC")]
    private readonly int MARGIN;
    [Token(Token = "0x400CEA3")]
    [FieldOffset(Offset = "0x10")]
    public float Space;
    [Token(Token = "0x400CEA4")]
    [FieldOffset(Offset = "0x14")]
    private int m_Max;

    [Token(Token = "0x600C1CD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Start()
    {
    }

    [Token(Token = "0x600C1CE")]
    [Address(RVA = "0x89F250", Offset = "0x89E050", VA = "0x1089F250", Slot = "4")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600C1CF")]
    [Address(RVA = "0x89F430", Offset = "0x89E230", VA = "0x1089F430", Slot = "5")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600C1D0")]
    [Address(RVA = "0x89F4F0", Offset = "0x89E2F0", VA = "0x1089F4F0")]
    public ScrollClamped_VersusTowerInfo()
    {
    }
  }
}
