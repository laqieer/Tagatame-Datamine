// Decompiled with JetBrains decompiler
// Type: Gsc.SDK
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gsc
{
  [Token(Token = "0x2003538")]
  public static class SDK
  {
    [Token(Token = "0x170021A7")]
    public static bool Initialized
    {
      [Token(Token = "0x600EBB4"), Address(RVA = "0xB0FEC0", Offset = "0xB0ECC0", VA = "0x10B0FEC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EBB5"), Address(RVA = "0xB0FF70", Offset = "0xB0ED70", VA = "0x10B0FF70")] private set
      {
      }
    }

    [Token(Token = "0x170021A8")]
    public static bool hasError
    {
      [Token(Token = "0x600EBB6"), Address(RVA = "0xB0FEF0", Offset = "0xB0ECF0", VA = "0x10B0FEF0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EBB7"), Address(RVA = "0xB0FFA0", Offset = "0xB0EDA0", VA = "0x10B0FFA0")] private set
      {
      }
    }

    [Token(Token = "0x170021A9")]
    public static Configuration Configuration
    {
      [Token(Token = "0x600EBB8"), Address(RVA = "0xB0FE80", Offset = "0xB0EC80", VA = "0x10B0FE80")] get
      {
        return new Configuration();
      }
      [Token(Token = "0x600EBB9"), Address(RVA = "0xB0FF20", Offset = "0xB0ED20", VA = "0x10B0FF20")] private set
      {
      }
    }

    [Token(Token = "0x600EBBA")]
    public static Coroutine Initialize<T>(Configuration.Builder<T> confBuilder, string specifiedEnv = null) where T : struct, Configuration.IEnvironment
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x600EBBB")]
    [Address(RVA = "0xB0F540", Offset = "0xB0E340", VA = "0x10B0F540")]
    public static void Reset()
    {
    }

    [Token(Token = "0x600EBBC")]
    [Address(RVA = "0xB0FBD0", Offset = "0xB0E9D0", VA = "0x10B0FBD0")]
    private static void _PreInit(IWebQueueObserver webQueueObserver)
    {
    }

    [Token(Token = "0x600EBBD")]
    [Address(RVA = "0xB0F720", Offset = "0xB0E520", VA = "0x10B0F720")]
    private static void _PostInit(Configuration conf)
    {
    }

    [Token(Token = "0x2003539")]
    private static class Initializer<T> where T : struct, Configuration.IEnvironment
    {
      [Token(Token = "0x600EBBE")]
      public static IEnumerator Initialize(
        Configuration.Builder<T> confBuilder,
        string specifiedEnv)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x600EBBF")]
      private static IEnumerator BuildConfigration(
        Configuration.Builder<T> confBuilder,
        string specifiedEnv)
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x600EBC0")]
      private static void SelectedEnvironment(
        Configuration.Builder<T> confBuilder,
        string envName,
        Configuration.IEnvironment env)
      {
      }
    }

    [Token(Token = "0x200353D")]
    public class BootLoader : MonoBehaviour
    {
      [Token(Token = "0x400FC91")]
      [FieldOffset(Offset = "0x0")]
      private static SDK.BootLoader currentLoader;
      [Token(Token = "0x400FC92")]
      [FieldOffset(Offset = "0xC")]
      private IEnumerator enumerator;

      [Token(Token = "0x600EBCF")]
      [Address(RVA = "0xB01E30", Offset = "0xB00C30", VA = "0x10B01E30")]
      public static void Run(IEnumerator enumerator)
      {
      }

      [Token(Token = "0x600EBD0")]
      [Address(RVA = "0xB01F90", Offset = "0xB00D90", VA = "0x10B01F90")]
      private IEnumerator Start() => (IEnumerator) null;

      [Token(Token = "0x600EBD1")]
      [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
      public BootLoader()
      {
      }
    }
  }
}
