// Decompiled with JetBrains decompiler
// Type: SRPG.TownQuestPeriodLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B6E")]
  [AddComponentMenu("UI/TownQuestPeriodLock")]
  public class TownQuestPeriodLock : MonoBehaviour
  {
    [Token(Token = "0x400D4A6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private TownQuestPeriodLock.PeriodlockTargets Target;
    [Token(Token = "0x400D4A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool isDraw;
    [Token(Token = "0x400D4A8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject LockObject;

    [Token(Token = "0x600C6FD")]
    [Address(RVA = "0x8F98C0", Offset = "0x8F86C0", VA = "0x108F98C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C6FE")]
    [Address(RVA = "0x8F99E0", Offset = "0x8F87E0", VA = "0x108F99E0")]
    public TownQuestPeriodLock()
    {
    }

    [Token(Token = "0x2002B6F")]
    [Flags]
    public enum PeriodlockTargets
    {
      [Token(Token = "0x400D4AA")] None = 1,
      [Token(Token = "0x400D4AB")] Genesis = 2,
      [Token(Token = "0x400D4AC")] Advance = 4,
    }
  }
}
