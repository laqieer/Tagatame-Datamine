// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiFilterItemFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002ACC")]
  [AddComponentMenu("UI/SortFilter/ArtiFilterItemFilter")]
  public class ArtiFilterItemFilter : MonoBehaviour
  {
    [Token(Token = "0x400D0C0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle ToggleFilter;
    [Token(Token = "0x400D0C1")]
    [FieldOffset(Offset = "0x10")]
    private int mIndex;
    [Token(Token = "0x400D0C2")]
    [FieldOffset(Offset = "0x14")]
    private FilterArtifactParam.Condition mCondition;

    [Token(Token = "0x17001A05")]
    public int Index
    {
      [Token(Token = "0x600C36C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001A06")]
    public FilterArtifactParam.Condition Condition
    {
      [Token(Token = "0x600C36D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (FilterArtifactParam.Condition) null;
      }
    }

    [Token(Token = "0x17001A07")]
    public bool IsOn
    {
      [Token(Token = "0x600C36E"), Address(RVA = "0x8BA3A0", Offset = "0x8B91A0", VA = "0x108BA3A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C36F"), Address(RVA = "0x8BA410", Offset = "0x8B9210", VA = "0x108BA410")] set
      {
      }
    }

    [Token(Token = "0x600C370")]
    [Address(RVA = "0x8BA350", Offset = "0x8B9150", VA = "0x108BA350")]
    public void SetToggleSilent(bool val)
    {
    }

    [Token(Token = "0x600C371")]
    [Address(RVA = "0x8BA230", Offset = "0x8B9030", VA = "0x108BA230")]
    public void SetItem(
      int index,
      FilterArtifactParam.Condition condition,
      UnityAction<bool> action = null)
    {
    }

    [Token(Token = "0x600C372")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiFilterItemFilter()
    {
    }
  }
}
