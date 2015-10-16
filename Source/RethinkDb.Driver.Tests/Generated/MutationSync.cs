




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class MutationSync : GeneratedTest {

        public MutationSync (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #1
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test1') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test1") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #2
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test1soft') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test1soft") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #3
                 /* ExpectedOriginal: ({'skipped':0, 'deleted':0, 'unchanged':0, 'errors':0, 'replaced':1, 'inserted':0}) */
                 var expected_ = r.hashMap("skipped", 0L).with("deleted", 0L).with("unchanged", 0L).with("errors", 0L).with("replaced", 1L).with("inserted", 0L);
                 
                 /* Original: r.db('test').table('test1soft').config().update({'durability':'soft'}) */
                 var obtained = runOrCatch( r.db("test").table("test1soft").config().update(r.hashMap("durability", "soft")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, mutation/sync.yaml, #4
             //Original: tbl = r.db('test').table('test1')
             
                 var tbl = (Table) (r.db("test").table("test1"));
             
             
             //JavaDef, mutation/sync.yaml, #5
             //Original: tbl_soft = r.db('test').table('test1soft')
             
                 var tbl_soft = (Table) (r.db("test").table("test1soft"));
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #6
                 /* ExpectedOriginal: partial({'created':1}) */
                 var expected_ = partial(r.hashMap("created", 1L));
                 
                 /* Original: tbl.index_create('x') */
                 var obtained = runOrCatch( tbl.indexCreate("x") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #7
                 /* ExpectedOriginal: ([{'ready':True, 'index':'x'}]) */
                 var expected_ = r.array(r.hashMap("ready", true).with("index", "x"));
                 
                 /* Original: tbl.index_wait('x').pluck('index', 'ready') */
                 var obtained = runOrCatch( tbl.indexWait("x").pluck("index", "ready") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #8
                 /* ExpectedOriginal: ({'synced':1}) */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl.sync() */
                 var obtained = runOrCatch( tbl.sync() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #9
                 /* ExpectedOriginal: ({'synced':1}) */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl_soft.sync() */
                 var obtained = runOrCatch( tbl_soft.sync() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #10
                 /* ExpectedOriginal: ({'synced':1}) */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl.sync() */
                 var obtained = runOrCatch( tbl.sync() ,
                                            new OptArgs()
                     .with("durability", "soft")
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #11
                 /* ExpectedOriginal: ({'synced':1}) */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl.sync() */
                 var obtained = runOrCatch( tbl.sync() ,
                                            new OptArgs()
                     .with("durability", "hard")
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #15
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test1') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test1") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #16
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test1soft') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test1soft") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
