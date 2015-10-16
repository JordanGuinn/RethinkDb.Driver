




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
    public class ChangefeedsTable : GeneratedTest {

        public ChangefeedsTable (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             //JavaDef, changefeeds/table.yaml, #1
             //Original: all = tbl.changes()
             
                 var all = maybeRun( (Changes) (tbl.changes()) );
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #2
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':2}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 2L));
                 
                 /* Original: tbl.insert([{'id':1}, {'id':2}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 1L), r.hashMap("id", 2L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #3
                 /* ExpectedOriginal: bag([{'old_val':null, 'new_val':{'id':1}}, {'old_val':null, 'new_val':{'id':2}}]) */
                 var expected_ = bag(r.array(r.hashMap("old_val", null).with("new_val", r.hashMap("id", 1L)), r.hashMap("old_val", null).with("new_val", r.hashMap("id", 2L))));
                 
                 /* Original: fetch(all, 2) */
                 var obtained = runOrCatch( fetch(all, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #4
                 /* ExpectedOriginal: partial({'errors':0, 'replaced':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("replaced", 1L));
                 
                 /* Original: tbl.get(1).update({'version':1}) */
                 var obtained = runOrCatch( tbl.get(1L).update(r.hashMap("version", 1L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #5
                 /* ExpectedOriginal: [{'old_val': {'id': 1}, 'new_val': {'id': 1, 'version': 1}}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L)).with("new_val", r.hashMap("id", 1L).with("version", 1L)));
                 
                 /* Original: fetch(all, 1) */
                 var obtained = runOrCatch( fetch(all, 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #6
                 /* ExpectedOriginal: partial({'errors':0, 'deleted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("deleted", 1L));
                 
                 /* Original: tbl.get(1).delete() */
                 var obtained = runOrCatch( tbl.get(1L).delete() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #7
                 /* ExpectedOriginal: [{'old_val': {'id': 1, 'version': 1}, 'new_val': None}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L).with("version", 1L)).with("new_val", null));
                 
                 /* Original: fetch(all, 1) */
                 var obtained = runOrCatch( fetch(all, 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, changefeeds/table.yaml, #8
             //Original: pluck = tbl.changes().pluck({'new_val':['version']})
             
                 var pluck = maybeRun( (Pluck) (tbl.changes().pluck(r.hashMap("new_val", r.array("version")))) );
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #9
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 1L));
                 
                 /* Original: tbl.insert([{'id':5, 'version':5}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 5L).with("version", 5L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #10
                 /* ExpectedOriginal: [{'new_val': {'version': 5}}] */
                 var expected_ = r.array(r.hashMap("new_val", r.hashMap("version", 5L)));
                 
                 /* Original: fetch(pluck, 1) */
                 var obtained = runOrCatch( fetch(pluck, 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, changefeeds/table.yaml, #11
             //Original: ordered = tbl.changes().order_by('id')
             
                 var ordered = maybeRun( (OrderBy) (tbl.changes().orderBy("id")) );
             
             
             //JavaDef, changefeeds/table.yaml, #12
             //Original: vtbl = r.db('rethinkdb').table('_debug_scratch')
             
                 var vtbl = (Table) (r.db("rethinkdb").table("_debug_scratch"));
             
             
             //JavaDef, changefeeds/table.yaml, #13
             //Original: allVirtual = vtbl.changes()
             
                 var allVirtual = maybeRun( (Changes) (vtbl.changes()) );
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #14
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':2}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 2L));
                 
                 /* Original: vtbl.insert([{'id':1}, {'id':2}]) */
                 var obtained = runOrCatch( vtbl.insert(r.array(r.hashMap("id", 1L), r.hashMap("id", 2L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #15
                 /* ExpectedOriginal: bag([{'old_val':null, 'new_val':{'id':1}}, {'old_val':null, 'new_val':{'id':2}}]) */
                 var expected_ = bag(r.array(r.hashMap("old_val", null).with("new_val", r.hashMap("id", 1L)), r.hashMap("old_val", null).with("new_val", r.hashMap("id", 2L))));
                 
                 /* Original: fetch(allVirtual, 2) */
                 var obtained = runOrCatch( fetch(allVirtual, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #16
                 /* ExpectedOriginal: partial({'errors':0, 'replaced':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("replaced", 1L));
                 
                 /* Original: vtbl.get(1).update({'version':1}) */
                 var obtained = runOrCatch( vtbl.get(1L).update(r.hashMap("version", 1L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #17
                 /* ExpectedOriginal: [{'old_val': {'id': 1}, 'new_val': {'id': 1, 'version': 1}}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L)).with("new_val", r.hashMap("id", 1L).with("version", 1L)));
                 
                 /* Original: fetch(allVirtual, 1) */
                 var obtained = runOrCatch( fetch(allVirtual, 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #18
                 /* ExpectedOriginal: partial({'errors':0, 'deleted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("deleted", 1L));
                 
                 /* Original: vtbl.get(1).delete() */
                 var obtained = runOrCatch( vtbl.get(1L).delete() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #19
                 /* ExpectedOriginal: [{'old_val': {'id': 1, 'version': 1}, 'new_val': None}] */
                 var expected_ = r.array(r.hashMap("old_val", r.hashMap("id", 1L).with("version", 1L)).with("new_val", null));
                 
                 /* Original: fetch(allVirtual, 1) */
                 var obtained = runOrCatch( fetch(allVirtual, 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, changefeeds/table.yaml, #20
             //Original: vpluck = vtbl.changes().pluck({'new_val':['version']})
             
                 var vpluck = maybeRun( (Pluck) (vtbl.changes().pluck(r.hashMap("new_val", r.array("version")))) );
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #21
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':1}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 1L));
                 
                 /* Original: vtbl.insert([{'id':5, 'version':5}]) */
                 var obtained = runOrCatch( vtbl.insert(r.array(r.hashMap("id", 5L).with("version", 5L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/table.yaml, #22
                 /* ExpectedOriginal: [{'new_val': {'version': 5}}] */
                 var expected_ = r.array(r.hashMap("new_val", r.hashMap("version", 5L)));
                 
                 /* Original: fetch(vpluck, 1) */
                 var obtained = runOrCatch( fetch(vpluck, 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
