#!/usr/bin/env bash
set -m
./perform_test.sh

if [ $? != 0 ] 
then
    exit 1
fi
exit 0

fg