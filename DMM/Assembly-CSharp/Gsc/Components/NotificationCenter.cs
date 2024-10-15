// Decompiled with JetBrains decompiler
// Type: Gsc.Components.NotificationCenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gsc.Components
{
  [Token(Token = "0x20035EA")]
  public class NotificationCenter
  {
    [Token(Token = "0x400FE2D")]
    [FieldOffset(Offset = "0x0")]
    private static NotificationCenter _instance;
    [Token(Token = "0x400FE2E")]
    [FieldOffset(Offset = "0x8")]
    private readonly Dictionary<System.Type, NotificationCenter.ObserverList> observers;

    [Token(Token = "0x17002269")]
    public static NotificationCenter Instance
    {
      [Token(Token = "0x600F04E"), Address(RVA = "0xB0D110", Offset = "0xB0BF10", VA = "0x10B0D110")] get
      {
        return (NotificationCenter) null;
      }
    }

    [Token(Token = "0x600F04F")]
    public void AddObserver<TMessage>(NotificationObserver<TMessage> observer) where TMessage : INotification
    {
    }

    [Token(Token = "0x600F050")]
    public void AddObserver<TMessage>(NotificationObserver<TMessage> observer, object sender) where TMessage : INotification
    {
    }

    [Token(Token = "0x600F051")]
    public void RemoveObserver<TMessage>(NotificationObserver<TMessage> observer) where TMessage : INotification
    {
    }

    [Token(Token = "0x600F052")]
    public void RemoveObserversWithSender<TMessage>(object sender) where TMessage : INotification
    {
    }

    [Token(Token = "0x600F053")]
    [Address(RVA = "0xB0CF60", Offset = "0xB0BD60", VA = "0x10B0CF60")]
    public void RemoveObserversWithSender(object sender)
    {
    }

    [Token(Token = "0x600F054")]
    [Address(RVA = "0xB0CDC0", Offset = "0xB0BBC0", VA = "0x10B0CDC0")]
    public void RemoveObserversWithSender(System.Type messageType, object sender)
    {
    }

    [Token(Token = "0x600F055")]
    public void Post<TMessage>(TMessage message, object sender = null) where TMessage : INotification
    {
    }

    [Token(Token = "0x600F056")]
    [Address(RVA = "0xB0D0A0", Offset = "0xB0BEA0", VA = "0x10B0D0A0")]
    public NotificationCenter()
    {
    }

    [Token(Token = "0x20035EB")]
    private class Observer
    {
      [Token(Token = "0x400FE2F")]
      [FieldOffset(Offset = "0x8")]
      public Behaviour target;
      [Token(Token = "0x400FE30")]
      [FieldOffset(Offset = "0xC")]
      public Delegate handler;
      [Token(Token = "0x400FE31")]
      [FieldOffset(Offset = "0x10")]
      public object sender;

      [Token(Token = "0x600F057")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Observer()
      {
      }
    }

    [Token(Token = "0x20035EC")]
    private class ObserverList
    {
      [Token(Token = "0x400FE32")]
      [FieldOffset(Offset = "0x8")]
      private readonly List<NotificationCenter.Observer> aliveObservers;
      [Token(Token = "0x400FE33")]
      [FieldOffset(Offset = "0x0")]
      private static readonly List<NotificationCenter.Observer> deadObservers;

      [Token(Token = "0x1700226A")]
      public bool isEmpty
      {
        [Token(Token = "0x600F058"), Address(RVA = "0xB0E1D0", Offset = "0xB0CFD0", VA = "0x10B0E1D0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600F059")]
      [Address(RVA = "0xB0DB60", Offset = "0xB0C960", VA = "0x10B0DB60")]
      public void AddObserver(Delegate handler, object sender)
      {
      }

      [Token(Token = "0x600F05A")]
      [Address(RVA = "0xB0DF20", Offset = "0xB0CD20", VA = "0x10B0DF20")]
      public void RemoveObserver(Delegate handler)
      {
      }

      [Token(Token = "0x600F05B")]
      [Address(RVA = "0xB0E000", Offset = "0xB0CE00", VA = "0x10B0E000")]
      public void RemoveObserversWithSender(object sender)
      {
      }

      [Token(Token = "0x600F05C")]
      public void Post<TMessage>(ref TMessage message, object sender)
      {
      }

      [Token(Token = "0x600F05D")]
      [Address(RVA = "0xB0DD60", Offset = "0xB0CB60", VA = "0x10B0DD60")]
      private void RemoveDeadObservers()
      {
      }

      [Token(Token = "0x600F05E")]
      [Address(RVA = "0xB0E160", Offset = "0xB0CF60", VA = "0x10B0E160")]
      public ObserverList()
      {
      }

      [Token(Token = "0x600F05F")]
      [Address(RVA = "0xB0E0E0", Offset = "0xB0CEE0", VA = "0x10B0E0E0")]
      static ObserverList()
      {
      }
    }
  }
}
