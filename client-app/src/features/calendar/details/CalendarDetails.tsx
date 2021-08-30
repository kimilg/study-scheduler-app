import axios from "axios";
import { observer } from "mobx-react-lite";
import React, { useState } from "react";
import { useEffect } from "react";
import { Card, Grid, Header, Icon, Item, Label, List, Menu } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import CalendarDetailedContent from "./CalendarDetailedContent";
import CalendarDetailedHeader from "./CalendarDetailedHeader";

export default observer(function CalendarDetails() {
    const { workStore: { works, loadWorks, loading } } = useStore();
    useEffect(() => {
        if (works === null || works!.length <= 1) loadWorks();
    }, [works, loadWorks]);

    if (loading) return <LoadingComponent content='Works loading' />

    return (
        <>
            <Grid>
                <Grid.Column width={12}>
                    <CalendarDetailedHeader />
                    <CalendarDetailedContent works={works}/>
                </Grid.Column>
                <Grid.Column width={4}>
                    <Header as='h2'>
                        <Icon name='setting' />
                        <Header.Content>
                            Works
                            <Header.Subheader>Choose work to edit!</Header.Subheader>
                        </Header.Content>
                        
                    </Header>
                    <Menu vertical fluid>
                        {works && works.map((work: any) => (
                            <Menu.Item as='a' style={{ paddingTop: 15, paddingBottom: 15 }}>
                                <Icon name='coffee' />
                                {work.title}
                            </Menu.Item>
                        ))
                        }
                    </Menu>
                </Grid.Column>
            </Grid>
        </>
    )
})